using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspector11 : MonoBehaviour
{
    [SerializeField]
    public int num;

    // Start is called before the first frame update
    void Start()
    {
        print(GetFactorial(num));

    }

    // Update is called once per frame
    void Update()
    {

    }

    int GetFactorial(int num)
    {
        print("=== 팩토리얼 메서드 ===");
        int result = 1;

        for (int i = num; i >= 1; i--)
        {
            result *= i;
        }

        return result;
    }
}
