using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspector5 : MonoBehaviour
{
    [SerializeField]
    public int num;

    // Start is called before the first frame update
    void Start()
    {
        print("=== 구구단 ===");

        for (int i = 1; i <= 9; i++)
        {
            print(num + " * " + i + " = " + num * i);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
