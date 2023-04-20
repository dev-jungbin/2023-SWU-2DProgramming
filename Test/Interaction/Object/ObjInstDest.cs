using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjInstDest : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = Instantiate(prefab);
        Destroy(obj, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
