using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DayManager : MonoBehaviour
{
    GameObject pot;
    GameObject memo;
    GameManager gameManager;
    // 초 변수 선언
    public float sec;
    // 타이머 텍스트
    public Text timerText;
    public Text dayText;
    
    // Start is called before the first frame update
    void Start()
    {
        // 해당 게임오브젝트의 컴포넌트 찾기
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        // 시작 위치 저장
        gameManager.originPowerFruitPosition = GameObject.Find("PowerFruit").transform.position;
        gameManager.originSpeedFruitPosition = GameObject.Find("SpeedFruit").transform.position;
        gameManager.originSoupPosition = GameObject.Find("Soup").transform.position;

        // memo 오브젝트 가져오기
        memo = GameObject.Find("memo");
        // 메모 오브젝트 숨기기(투명화)
        memo.GetComponent<SpriteRenderer>().color = Color.clear;
        // 날짜 텍스트 설정
        dayText.text = (gameManager.currentLevel.ToString() + "일 차");

    }

    // Update is called once per frame
    void Update()
    {
        Timer(); // 타이머 실행
    }

    public void Timer()
    {
        // 초 받아오기
        sec += Time.deltaTime;
        // timerText에 time -> string으로 포매팅하여 text 설정
        timerText.text = string.Format("해가 지기까지 남은 시간 {0:D2}초", 14 - (int)sec);

        // 만약 14초가 넘어갔을 경우
        if ((int)sec > 14)
        {
            // 초를 0으로 초기화
            sec = 0;
            // Night Scene으로 변경
            SceneManager.LoadScene("NightScene");
        }
    }
}
