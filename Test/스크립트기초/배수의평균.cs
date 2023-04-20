using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspector8 : MonoBehaviour
{
    int[] a = new int[7];

    [SerializeField]
    public int num;

    // Start is called before the first frame update
    void Start()
    {
        print("=== 배수의 평균 ===");

        float average;

        int sum = 0;
        int count = 0;

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = Random.Range(1, 100);

            if (a[i] % num == 0)
            {
                sum += a[i];
                count += 1;
            }
        }

        average = (float)sum / count;

        print(num + "의 배수에 해당하는 값들의 평균: " + average);

    }

    // Update is called once per frame
    void Update()
    {

    }


}
