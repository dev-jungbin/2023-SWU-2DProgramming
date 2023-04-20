using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjZoomInOutWithMouseWheel : MonoBehaviour
{
    Vector3 zoomIn = new Vector3(2, 2, 1);
    Vector3 zoomOut = new Vector3(0.5f, 0.5f, 1);

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mouseScrollDelta.y > 0)
        {
            transform.localScale = zoomIn;
        }
        else if (Input.mouseScrollDelta.y < 0)
        {
            transform.localScale = zoomOut;
        }
    }
}
