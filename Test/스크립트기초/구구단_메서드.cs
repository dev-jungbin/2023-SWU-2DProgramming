using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspector10 : MonoBehaviour
{
    [SerializeField]
    public int num;

    // Start is called before the first frame update
    void Start()
    {
        PrintGugudan(num);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void PrintGugudan(int num)
    {
        print("=== 구구단 메서드 ===");

        for (int i = 1; i <= 9; i++)
        {
            print(num + " * " + i + " = " + num * i);
        }
    }
}
