using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjZoomOut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 zoom = new Vector3(0.5f, 0.5f, 1);
        transform.localScale = zoom;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
