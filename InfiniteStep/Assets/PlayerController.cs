using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Load Scene 사용에 필요

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;

    float junpForce = 680.0f;
    float walkForce = 5.0f;
    float maxWalkSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // 점프 (이중 점프 방)
        if (Input.GetKeyDown(KeyCode.Space) && this.rigid2D.velocity.y == 0)
        {
            this.animator.SetTrigger("JumpTrigger"); // 점프 애니메이션 실행
            this.rigid2D.AddForce(transform.up * this.junpForce);
        }

        // 좌우 이동
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        // 플레이어 속도
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        // 스피드 제한
        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        // 움직이는 방향에 따라 반전
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        // 플레이어 속도에 맞춰 애니메이션 속도 바꿈
        this.animator.speed = speedx / 2.0f;

        // 플레이어가 화면 밖으로 나갔다면 처음부터
        if (transform.position.y < -10)
        {
            SceneManager.LoadScene("GameScene");
        }

        // 플레이어 속도에 맞춰 애니메이션 속도 변경
        if (this.rigid2D.velocity.y == 0)
        {
            this.animator.speed = speedx / 2.0f;
        }
        else
        {
            this.animator.speed = 1.0f;
        }

    }
    // 골 도착
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("골");
        SceneManager.LoadScene("ClearScene");
    }
}
