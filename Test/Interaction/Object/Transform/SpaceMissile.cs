using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceMissile : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 pos = new Vector3(
                Random.Range(-3f, 3f),
                Random.Range(-3f, 3f),
                0
                );

            prefab.transform.position = pos;
            Instantiate(prefab);
        }
    }
}
