using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspector17 : MonoBehaviour
{
    VectorCalculator calculator = new VectorCalculator();

    [SerializeField]
    public Vector2 a;
    public Vector2 b;

    // Start is called before the first frame update
    void Start()
    {
        print("=== 벡터의 사칙 연산 클래스 ===");

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

public class VectorCalculator
{
    public Vector2 GetPlus(Vector2 a, Vector2 b)
    {
        return a + b;
    }

    public Vector2 GetMinus(Vector2 a, Vector2 b)
    {
        return a - b;
    }

    public Vector2 GetMultiply(Vector2 a, Vector2 b)
    {
        return a * b;
    }

    public Vector2 GetDivide(Vector2 a, Vector2 b)
    {
        return a / b;
    }
}