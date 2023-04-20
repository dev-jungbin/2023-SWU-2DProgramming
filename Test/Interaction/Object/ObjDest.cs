using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjDest : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(obj, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
