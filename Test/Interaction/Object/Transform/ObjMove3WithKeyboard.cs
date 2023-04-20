using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjMove3WithKeyboard : MonoBehaviour
{
    Vector3 moveY = new Vector3(0, 1, 0);
    Vector3 moveX = new Vector3(1, 0, 0);

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(moveY * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-moveY * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-moveX * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(moveX * Time.deltaTime, Space.World);
        }
    }
}