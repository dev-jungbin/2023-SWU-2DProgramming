using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjAngle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float angle = Random.Range(0, 90);

        transform.eulerAngles = new Vector3(0, 0, angle);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
