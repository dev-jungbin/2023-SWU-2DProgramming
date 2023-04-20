using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspector16 : MonoBehaviour
{
    FloatCalculator calculator = new FloatCalculator();

    [SerializeField]
    public float a;
    public float b;

    // Start is called before the first frame update
    void Start()
    {
        print("=== 실수의 사칙 연산 클래스 ===");

        print(calculator.GetPlus(a, b));
        print(calculator.GetMinus(a, b));
        print(calculator.GetMultiply(a, b));
        print(calculator.GetDivide(a, b));

    }

    // Update is called once per frame
    void Update()
    {

    }


}

public class FloatCalculator
{
    public float GetPlus(float a, float b)
    {
        return a + b;
    }

    public float GetMinus(float a, float b)
    {
        return a - b;
    }

    public float GetMultiply(float a, float b)
    {
        return a * b;
    }

    public float GetDivide(float a, float b)
    {
        return a / b;
    }
}