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
        print("접촉");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        print("분리");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        print("물리vs물리");
    }
}
