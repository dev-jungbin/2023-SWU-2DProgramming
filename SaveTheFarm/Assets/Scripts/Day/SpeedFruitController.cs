using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedFruitController : MonoBehaviour
{
    // 오브젝트가 항아리 위에 있는지 없는지 판단하는 flag 변수
    public bool isOnPot = false;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 충돌 해제 시 Pot과 부딪혔는지 판단
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pot")
        {
            this.isOnPot = true;
        }
    }

    // 충돌 해제 시 Pot과 멀어졌는지 판단
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pot")
        {
            this.isOnPot = false;
        }
    }
}
