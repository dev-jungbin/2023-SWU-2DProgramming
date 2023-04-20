using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjPos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = new Vector3(
            Random.Range(-3f, 3f),
            Random.Range(-3f, 3f),
            0
            );

        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
