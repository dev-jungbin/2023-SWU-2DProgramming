using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjScale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 scale = new Vector3(
            Random.Range(0.1f, 2f),
            Random.Range(0.1f, 2f),
            1
            );

        transform.localScale = scale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
