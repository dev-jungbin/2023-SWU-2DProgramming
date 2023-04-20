using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBSpaceJump : MonoBehaviour
{
    Vector2 forceY = new Vector2(0, 500);
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // 점프할 때에는 GetKeyDown으로 하고, Time.deltaTime 지우기
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(forceY);
        }
    }
}
