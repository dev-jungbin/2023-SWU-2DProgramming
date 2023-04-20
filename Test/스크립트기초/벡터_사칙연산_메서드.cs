using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspector15 : MonoBehaviour
{
    [SerializeField]
    public Vector2 a;
    public Vector2 b;

    // Start is called before the first frame update
    void Start()
    {
        print("=== 벡터의 사칙 연산 메서드 ===");

        print(GetPlus(a, b));
        print(GetMinus(a, b));
        print(GetMultiply(a, b));
        print(GetDivide(a, b));

    }

    // Update is called once per frame
    void Update()
    {

    }

    Vector2 GetPlus(Vector2 a, Vector2 b)
    {
        return a + b;
    }

    Vector2 GetMinus(Vector2 a, Vector2 b)
    {
        return a - b;
    }

    Vector2 GetMultiply(Vector2 a, Vector2 b)
    {
        return a * b;
    }

    Vector2 GetDivide(Vector2 a, Vector2 b)
    {
        return a / b;
    }
}
