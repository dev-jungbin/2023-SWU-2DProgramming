using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBCollision1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.name);
        Destroy(collision.gameObject, 1);
    }
}
