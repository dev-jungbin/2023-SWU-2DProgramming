using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class Vector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector0();
        Vector1();
        Vector2();
        Vector3();
        Vector4();
        Vector5();
        Vector6();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Vector0() {
        print("=== 초기화 & 대입 ===");

        Vector2 v1 = new Vector2(1.2f, 3.4f);
        print(v1);

        Vector2 v2 = v1;
        print(v2);
    }

    void Vector1() {
        print("=== 벡터의 길이 ===");

        Vector2 vec = new Vector2(2, 3);
        float len = vec.magnitude;
        print(len);
    }

    void Vector2() {
        print("=== 두 지점 사이의 거리 ===");

        Vector2 vec1 = new Vector2(2, 1);
        Vector2 vec2 = new Vector2(8, 5);

        float distance = (float) Math.Sqrt(Math.Pow(vec1.x - vec2.x, 2) + Math.Pow(vec1.y - vec2.y, 2));
        
        print(distance);
    }

    void Vector3() {
        print("=== 사칙 연산 ===");

        Vector2 v1 = new Vector2(1, 2);
        Vector2 v2 = new Vector2(3, 4);

        CalcVec(v1, v2);
    }

    void CalcVec(Vector2 a, Vector2 b) {
        Vector2 add = a + b;
        Vector2 sub = a - b;
        Vector2 mul = a * b;
        Vector2 div = a / b;

        print(add);
        print(sub);
        print(mul);
        print(div);
    }

    void Vector4() {
        print("=== 도착 지점 위치 ===");

        Vector2 startVector = new Vector2(2, 3);
        Vector2 endVector = new Vector2(4, 5);

        print(startVector + endVector);
    }

    void Vector5() {
        print("=== 난수 생성 ===");

        int num = Random.Range(-3, 4);
        print(num);

        float val = Random.Range(-3f, 3f);
        print(val);
    }

    void Vector6() {
        print("=== 난수 배열 ===");

        int[] arr = new int[5];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Random.Range(-10, 11);
        }

        string printStr = "";
        for (int i = 0; i < arr.Length; i++)
        {
            printStr += arr[i] + " ";
        }
        print(printStr);
    }
}