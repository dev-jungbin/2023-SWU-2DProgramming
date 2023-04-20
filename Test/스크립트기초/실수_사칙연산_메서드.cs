using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspector14 : MonoBehaviour
{
    [SerializeField]
    public float a;
    public float b;

    // Start is called before the first frame update
    void Start()
    {
        print("=== 실수의 사칙 연산 메서드 ===");

        print(GetPlus(a, b));
        print(GetMinus(a, b));
        print(GetMultiply(a, b));
        print(GetDivide(a, b));

    }

    // Update is called once per frame
    void Update()
    {

    }

    float GetPlus(float a, float b)
    {
        return a + b;
    }

    float GetMinus(float a, float b)
    {
        return a - b;
    }

    float GetMultiply(float a, float b)
    {
        return a * b;
    }

    float GetDivide(float a, float b)
    {
        return a / b;
    }
}
