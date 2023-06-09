using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 moveY = new Vector3(0, 3, 0);
    Vector3 moveX = new Vector3(4, 0, 0);
    Animator animator;
    public GameObject missile;
    int bulletCount = 0;
    int maxBulletCount = 5;
    private GameObject[] bullets;

    void Start()
    {
        this.animator = GetComponent<Animator>(); // 애니메이터 컴포넌트 지정
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
    }
