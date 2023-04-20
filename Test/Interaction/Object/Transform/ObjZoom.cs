using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjZoom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 zoom = new Vector3(2, 2, 1);
        transform.localScale = zoom;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
