using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjSpin3 : MonoBehaviour
{
    Vector3 spinZ = new Vector3 (0, 0, -90);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(spinZ * Time.deltaTime);
    }
}
