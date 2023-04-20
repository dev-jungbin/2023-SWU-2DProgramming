using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjMove3 : MonoBehaviour
{
    Vector3 moveY = new Vector3(0, 1, 0);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveY * Time.deltaTime, Space.World);
    }
}
