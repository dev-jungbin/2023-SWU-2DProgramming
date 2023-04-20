using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;

public class Array : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Array0();
        Array1();
        Array2();
        Array3();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Array0() {
        print("=== 배열 생성&대입 ===");

        int[] arr = new int[5];

        arr[0] = 83;
        arr[1] = 99;
        arr[2] = 52;
        arr[3] = 93;
        arr[4] = 15;

        for (int i = 0; i < arr.Length; i++) {
            print(arr[i]);
        }
    }

    void Array1()
    {
        print("=== 배열 초기화 ===");

        int[] arr = { 88, 99, 52, 93, 15 };

        for (int i = 0; i < arr.Length; i++)
        {
            print(arr[i]);
        }
    }

    void Array2() {
        print("=== 배열 요소 출력 ===");

        int[] arr = { 43, 59, 32, 73, 65 };
        print("50 이상의 값");
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 50)
            {
                print(arr[i]);
            }
        }

        print("홀수 번째 요소");
        for (int i = 0; i < arr.Length; i++)
        {
            if ((i + 1) % 2 != 0) {
                print(arr[i]);
            }
        }
    }

    void Array3() {
        print("=== 배열의 합 & 평균 ===");

        int[] arr = { 1, 9, 6, 3, 7 };

        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        print("모든 요소들의 합: " + sum);
        print("모든 요소들의 평균(실수): " + (float) sum / arr.Length);

    }
}
