using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBTrigger : MonoBehaviour
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
        print("겹침");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        print("분리");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        print("일반vs일반");
    }
}
