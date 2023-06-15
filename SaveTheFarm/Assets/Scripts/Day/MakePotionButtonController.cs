using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePotionButtonController : MonoBehaviour
{
    PowerFruitController powerFruit;
    SpeedFruitController speedFruit;
    SoupController soup;
    GameObject pot;
    GameObject powerDone;
    GameObject speedDone;
    GameManager gameManager;

    // 시간 지연을 위한 변수 정의
    float stunTime = 1f;
    float tickTime;

    // Start is called before the first frame update
    void Start()
    {
        // 해당 게임오브젝트의 컴포넌트 찾기
        powerFruit = GameObject.Find("PowerFruit").GetComponent<PowerFruitController>();
        speedFruit = GameObject.Find("SpeedFruit").GetComponent<SpeedFruitController>();
        soup = GameObject.Find("Soup").GetComponent<SoupController>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        // 제조 성공 이미지 오브젝트 찾기
        powerDone = GameObject.Find("power_done");
        speedDone = GameObject.Find("speed_done");

        // 제조 성공 이미지 처음에 투명 처리
        powerDone.GetComponent<SpriteRenderer>().color = Color.clear;
        speedDone.GetComponent<SpriteRenderer>().color = Color.clear;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        // powerFruit와 soup 둘 다 pot과 충돌해 있으면
        if (powerFruit.isOnPot && soup.isOnPot)
        {
            // 파워 1 증가
            gameManager.power += 1;

            // 아이템 위치 초기화
            GameObject.Find("PowerFruit").transform.position = gameManager.originPowerFruitPosition;
            GameObject.Find("Soup").transform.position = gameManager.originSoupPosition;

            // 파워 물약 제조 성공 이미지 보이게 처리
            powerDone.GetComponent<SpriteRenderer>().color = Color.white;

            // 0.5초 후 이미지 숨김
            Invoke("HideDoneImage", 0.5f);
        }
        else if (speedFruit.isOnPot && soup.isOnPot) // speedFruit와 soup 둘 다 pot과 충돌해 있으면
        {
            // speed 1 증가
            gameManager.speed += 0.1f;

            // 아이템 위치 초기화
            GameObject.Find("SpeedFruit").transform.position = gameManager.originSpeedFruitPosition;
            GameObject.Find("Soup").transform.position = gameManager.originSoupPosition;

            // 파워 물약 제조 성공 이미지 보이게 처리
            speedDone.GetComponent<SpriteRenderer>().color = Color.white;

            // 1초 후 이미지 숨김
            Invoke("HideDoneImage", 1);
        }
    }

    private void HideDoneImage()
    {
        // 제조 성공 이미지 투명 처리
        powerDone.GetComponent<SpriteRenderer>().color = Color.clear;
        speedDone.GetComponent<SpriteRenderer>().color = Color.clear;
    }
}
