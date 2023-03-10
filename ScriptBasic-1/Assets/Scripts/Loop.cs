using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LoopStart();
        ForExample1();
        ForExample2();
        ForExample3();
        ForExample4();
        ForExample5();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoopStart() {
        print("=== LoopStart ===");

        for (int i = 0; i < 5; i++)
        {
            print(i);
        }
    }

    void ForExample1() {
        print("=== ForExample 1 ===");

        for (int i = 3; i < 8; i++) {
            print(i);
        }
    }

    void ForExample2() {
        print("=== ForExample 2 ===");

        for (int i = 4; i >= 0; i--) {
            print(i);
        }
    }

    void ForExample3() {
        print("=== ForExample 3 ===");

        for (int i = 1; i < 10; i = i + 2) {
            print(i);
        }
    }

    void ForExample4() {
        print("=== ForExample 4 ===");

        for (int i = 10; i > 0; i = i - 3) {
            print(i);
        }
    }

    void ForExample5() {
        print("=== ForExample 5 ===");
        int sum = 0;
        int count = 0;
        for (int i = 3; i <= 9; i++) {
            sum = sum + i;
            count++;
        }
        print("합: " + sum.ToString());
        print("평균: " + (sum / count).ToString());
    }
}
