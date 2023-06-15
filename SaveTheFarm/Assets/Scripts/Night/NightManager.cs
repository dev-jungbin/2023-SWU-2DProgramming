using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NightManager : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    private float spawnPosY = 4.8f;
    public int dayLevel = 1;


    // 생성된 적 받아오는 배열
    private GameObject[] enemies;

    private GameObject newEnemy;
    GameManager gameManager;

    // 시간 지연을 위한 변수 정의
    float stunTime = 1f;
    float tickTime;

    // 농장 HP bar Image를 저장하기 위한 변수
    public Image hpBar;
    // 생명 게이지 초기 색상, 현재 색상 변수
    Color initColor = Color.green;
    Color currColor;

    // 초 변수 선언
    public float sec;
    // 타이머 텍스트
    public Text timerText;
    public Text dayText;
    void Start()
    {
        // 게임 매니저 컴포넌트 호출
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        // hp bar 가져오기
        hpBar = GameObject.Find("FarmImage-Bar").GetComponent<Image>();

        // 생명 게이지 초기 색상 설정
        hpBar.color = initColor;
        currColor = initColor;

        // 날짜 텍스트 설정
        dayText.text = (gameManager.currentLevel.ToString() + "일 차");

    }

    // Update is called once per frame
    void Update()
    {
        Timer(); // 타이머 실행

        tickTime += Time.deltaTime;
        if (tickTime >= stunTime)
        {
            CreateEnemy();
            tickTime = 0;
        }

        DisplayHpBar();
    }

    // 적(Enemy) 생성 함수
    void CreateEnemy()
    {
        // 생성되어 있는 적 가져오기
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        // 레벨별 생성 가능한 최대 적 수 설정
        if (enemies.Length < 3 * gameManager.currentLevel)
        {
            this.newEnemy = this.enemyPrefab[Random.Range(0, 5)];

            // 적이 생성될 x좌표 랜덤 생성
            float randomX = Random.Range(-8.0f, 8.0f);

            // 적이 생성될 pos 정의
            Vector3 pos = new Vector2(randomX, this.spawnPosY);

            // new Enemy 좌표 설정
            this.newEnemy.transform.position = pos;

            // enemy 생성
            Instantiate(newEnemy);
        }
    }

    private void DisplayHpBar()
    {
        float ratio = gameManager.homeHP / 100.0f;
        // 생명 수치가 50%일 때까지는 녹색에서 노란색으로 변경
        if (ratio > 0.5f)
            currColor.r = (1 - ratio) * 2.0f;
        else // 생명 수치가 0%일 때까지는 노란색에서 빨간색으로 변경
            currColor.g = ratio * 2.0f;
        // HP bar의 색상 변경
        hpBar.color = currColor;
        // HP bar의 크기 변경
        hpBar.fillAmount = ratio;
    }

    public void Timer()
    {
        // 초 받아오기
        sec += Time.deltaTime;
        // timerText에 time -> string으로 포매팅하여 text 설정
        timerText.text = string.Format("해가 뜨기까지 남은 시간 {0:D2}초", 30 - (int)sec);

        // 만약 29초가 넘어갔을 경우
        if ((int)sec > 29)
        {
            // 초를 0으로 초기화
            sec = 0;

            // 만약 아직 3일이 지나지 않았다면
            if (gameManager.currentLevel < 3)
            {
                // Day Scene으로 변경, 날짜 증가
                gameManager.currentLevel += 1;
                SceneManager.LoadScene("DayScene");
            }
            else // 3일이 지났다면 게임 클리어 씬으로 변경
            {
                gameManager.GameClear();
            }

        }
    }
}
