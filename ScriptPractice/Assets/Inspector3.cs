using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspector3 : MonoBehaviour
{
    [SerializeField]
    public int a;
    public int b;

    // Start is called before the first frame update
    void Start()
    {
        print("=== 사칙연산 ===");

        print(a + b);
        print(a - b);
        print(a * b);
        print((float) a / b);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
