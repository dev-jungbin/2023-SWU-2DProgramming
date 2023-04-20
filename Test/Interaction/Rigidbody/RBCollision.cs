using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("立盟");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        print("盒府");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        print("拱府vs拱府");
    }
}
