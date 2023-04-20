using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardSpace : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("발사준비");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            print("발사중지");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            print("발사 중");
        }
    }
}
