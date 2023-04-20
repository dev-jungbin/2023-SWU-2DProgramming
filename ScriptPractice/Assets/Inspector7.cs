using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspector7 : MonoBehaviour
{
    int[] a = new int[5];

    // Start is called before the first frame update
    void Start()
    {
        print("=== 짝수의 평균 ===");

        float oddAverage;
        float evenAverage;

        int oddSum = 0;
        int evenSum = 0;

        int oddCount = 0;
        int evenCount = 0;

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = Random.Range(1, 11);

            if (a[i] % 2 == 0)
            {
                evenSum += a[i];
                evenCount += 1;
            }
            else
            {
                oddSum += a[i];
                oddCount += 1;
            }
        }

        evenAverage = (float)evenSum / evenCount;
        oddAverage = (float)oddSum / oddCount;

        print("짝수 평균: " + evenAverage);
        print("홀수 평균: " + oddAverage);

    }

    // Update is called once per frame
    void Update()
    {

    }


}
