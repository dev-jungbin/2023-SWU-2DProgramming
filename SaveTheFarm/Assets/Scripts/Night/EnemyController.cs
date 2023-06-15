using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    public enum State
    {
        WALKING,
        STUN
    }

    Vector3 moveY;
    Vector3 stunY = new Vector3(0, 1f, 0);
    int HP = 10;
    int power = 3;

    GameManager gameManager;
    public GameObject wall;

    // 시간 지연을 위한 변수 정의
    float stunTime = 0.7f;
    float tickTime;
    

    // 상태를 저장할 변수
    public State state = State.WALKING;

    // Start is called before the first frame update
    void Start()
    {
        // 게임 매니저 컴포넌트 호출
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        // 레벨별 적 캐릭터 스피드 조절
        moveY = new Vector3(0, gameManager.currentLevel * 0.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {

        switch (state) // 상태에 따라 분기처리
        {
            case State.WALKING:
                // 적 아래로 이동
                transform.position -= moveY * Time.deltaTime;

                // 적이 성벽에 닿았을 경우
                if (transform.position.y <= wall.transform.position.y)
                {
                    state = State.STUN;
                }
                return;
            case State.STUN:
                transform.position += stunY * Time.deltaTime;
                
                tickTime += Time.deltaTime;
                if (tickTime >= stunTime)
                {
                    state = State.WALKING;
                    tickTime = 0;
                }
                return;
        }
    }

    // 충돌 처리
    void OnTriggerEnter2D(Collider2D other)
    {
        // 총알이 들어왔을 경우
        if (other.gameObject.tag == "Bullet")
        {
            // 총알 삭제
            Destroy(other.gameObject);

            // 체력이 남았을 경우
            if (HP > 3)
            {
                HP -= gameManager.power; // 체력 감소
                state = State.STUN; // 스턴
            }
            else // 체력이 다했을 경우 사망, 캐릭터 삭제
            {
                Destroy(this.gameObject);
            }
        }

        // 성벽에 닿았을 경우
        if (other.gameObject.tag == "Wall")
        {

            // 홈 체력이 남았을 경우
            if (gameManager.homeHP > 0)
            {
                gameManager.homeHP -= power; // 홈 체력 감소
                state = State.STUN; // 스턴
            }
            else // 홈 체력이 다했을 경우 게임 실패 처리
            {
                gameManager.GameOver();
            }
        }

        // 플레이어에 닿았을 경우
        if (other.gameObject.tag == "Player")
        {
            state = State.STUN;  // 스턴
        }
    }


}
