using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBTrigger1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.gameObject.name + "�� �浹");
        Destroy(collision.gameObject, 1);
    }
}
