using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspector1 : MonoBehaviour
{
    [SerializeField]
    public bool a;
    public float b;
    public string c;
    public Vector2 d;

    // Start is called before the first frame update
    void Start()
    {
        print(a);
        print(b);
        print(c);
        print(d);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
