using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjSpinWithMouse2 : MonoBehaviour
{
    Vector3 spinZ = new Vector3 (0, 0, 90);
    Vector3 spinZR = new Vector3(0, 0, -90);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(spinZ * Time.deltaTime);
        }

        if (Input.GetMouseButton(1))
        {
            transform.Rotate(spinZR * Time.deltaTime);
        }
    }
}
