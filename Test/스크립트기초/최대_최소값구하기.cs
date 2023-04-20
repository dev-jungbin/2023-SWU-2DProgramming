using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspector9 : MonoBehaviour
{
    int[] a = new int[9];

    // Start is called before the first frame update
    void Start()
    {
        print("=== 최대/최소값 구하기 ===");

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = Random.Range(1, 30);
        }

        int max = a[0];
        int min = a[0];

        for (int i = 0; i < a.Length; i++)
        {
            if (max < a[i])
            {
                max = a[i];
            }

            if (min > a[i])
            {
                min = a[i];
            }
        }

        print("max: " + max);
        print("min: " + min);
    }

    // Update is called once per frame
    void Update()
    {

    }


}
