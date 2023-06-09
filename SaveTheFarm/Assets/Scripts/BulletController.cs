using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // 미사일 속도
    Vector3 moveY = new Vector3(0, 3, 0);

    void Start()
    {

    }

    void Update()
    {
        // 미사일 움직이기
        transform.Translate(moveY * Time.deltaTime);
    }

    void OnBecameInvisible()
    {
        // 만약 화면 밖으로 나갈 경우 미사일 제거
        Destroy(gameObject);
    }
}
