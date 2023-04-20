using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspector4 : MonoBehaviour
{
    [SerializeField]
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        print("=== 학점 출력 ===");

        if (score >= 90)
        {
            print("A");
        }
        else if (score >= 80)
        {
            print("B");
        }
        else if (score >= 70)
        {
            print("C");
        }
        else if (score < 50)
        {
            print("E");
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
