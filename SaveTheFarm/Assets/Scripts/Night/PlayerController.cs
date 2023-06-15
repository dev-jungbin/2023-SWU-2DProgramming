using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Vector3 moveY;
    Vector3 moveX;
    Animator animator;
    public GameObject missile;
    int bulletCount = 0;
    int maxBulletCount = 7;
    int hp = 100;
    private GameObject[] bullets;
    GameManager gameManager;
    // HP bar Image를 저장하기 위한 변수
    public Image hpBar;
    // 생명 게이지 초기 색상, 현재 색상 변수
    Color initColor = Color.green;
    Color currColor;

    void Start()
    {
        // 게임 매니저 컴포넌트 호출
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        this.animator = GetComponent<Animator>(); // 애니메이터 컴포넌트 지정
        moveX = new Vector3(gameManager.speed * 3, 0, 0); 
        moveY = new Vector3(0, gameManager.speed * 3, 0);

        // 생명 게이지 초기 색상 설정
        hpBar.color = initColor;
        currColor = initColor;
    }

    void Update()
    {
        MovePlayer();
        ShootMissile();
    }

    void MovePlayer()
    {
        // 위쪽 화살표 키를 눌렀을 경우
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(moveY * Time.deltaTime); // 위쪽으로 이동
        }

        // 아래쪽 화살표 키를 눌렀을 경우
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-moveY * Time.deltaTime); // 아래쪽으로 이동
        }

        // 오른쪽 화살표 키를 눌렀을 경우
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(moveX * Time.deltaTime); // 오른쪽으로 이동
        }

        // 왼쪽 화살표 키를 눌렀을 경우
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-moveX * Time.deltaTime); // 왼쪽으로 이동
        }
    }

    void ShootMissile()
    {
        // 스페이스 키 눌렀을 경우
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bullets = GameObject.FindGameObjectsWithTag("Bullet");
            // Bullet 태그를 이용해서 미사일 개수 판단
            bulletCount = GameObject.FindGameObjectsWithTag("Bullet").Length;

            if (bulletCount < maxBulletCount)
            {
                // 플레이어 좌표와 동일한 곳으로 미사일 좌표 생성
                Vector3 pos = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, 0);

                // 미사일 좌표 설정
                missile.transform.position = pos;

                // 미사일 생성
                Instantiate(missile);
            }
            else
            {
                // 가장 처음에 생성된 미사일 제거
                Destroy(bullets[0]);

                // 플레이어 좌표와 동일한 곳으로 미사일 좌표 생성
                Vector3 pos = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, 0);

                // 미사일 좌표 설정
                missile.transform.position = pos;

                // 미사일 생성
                Instantiate(missile);
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 만약 적과 충돌한다면
        if (collision.tag == "Enemy")
        {
            // hp가 남아있다면
            if (hp > 2)
            {
                // 적의 파워 3 * 현재 레벨만큼 hp 감소
                hp -= 3 * gameManager.currentLevel;
                // HpBar 업데이트
                DisplayHpBar();
            }
            else // hp가 남아있지 않다면
            {
                // 게임 오버
                gameManager.GameOver();
            }
        }
    }

    private void DisplayHpBar()
    {
        float ratio = hp / 100.0f;
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
}
