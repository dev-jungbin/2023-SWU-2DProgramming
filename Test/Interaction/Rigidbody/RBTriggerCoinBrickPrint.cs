using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBTriggerCoinBrickPrint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            print("동전");
        } else if (collision.gameObject.tag == "Brick")
        {
            print("벽돌"); 
        }
    }
}
