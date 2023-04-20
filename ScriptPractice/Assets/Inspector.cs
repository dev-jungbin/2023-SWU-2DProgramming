using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspector : MonoBehaviour
{
    [SerializeField]
    private int a;

    public int b;

    // Start is called before the first frame update
    void Start()
    {
        print(a);
        print(b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
