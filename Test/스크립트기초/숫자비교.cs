using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspector2 : MonoBehaviour
{
    [SerializeField]
    public int a;
    public int b;

    // Start is called before the first frame update
    void Start()
    {
        print("=== 숫자 비교 ===");

        int max;
        int min;

        if (a > b)
        {
            max = a;
            min = b;
        }
        else if (a == b)
        {
            print("두 수는 같습니다.");
            return;
        }
        else
        {
            max = b;
            min = a;
        }

        print("max: " + max);
        print("min: " + min);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
