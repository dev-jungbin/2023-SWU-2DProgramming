using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Example0();
        Example1();
        Example2();
        Example3();
        Example4();
        Example5();
        Example6();
        Example7();
        Example8();
        Example9();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Example0() 
    {
        print("=== Example 0 ===");

        int a = 27;
        int b = a;

        print(b);
    }

    void Example1()
    {
        print("=== Example 1 ===");

        float a = 3.4f;
        float b = a;

        print(b);
    }

    void Example2()
    {
        print("=== Example 2 ===");

        bool a = false;
        bool b = a;

        print(b);
    }

    void Example3()
    {
        print("=== Example 3 ===");

        string s1 = "Swuni";
        string s2 = s1;

        print(s2);
    }

    void Example4()
    {
        print("=== Example 4 ===");

        int a = 7;
        int b = 3;

        print(a + b);
        print(a - b);
        print(a * b);
        print(a / b);
    }

    void Example5()
    {
        print("=== Example 5 ===");

        float a = 2.5f;
        float b = 3.4f;

        print(a + b);
        print(a - b);
        print(a * b);
        print(a / b);
    }

    void Example6()
    {
        print("=== Example 6 ===");

        int a = 1;

        print(a + 1);
        print(a++);
        print(a += 1);
    }

    void Example7()
    {
        print("=== Example 7 ===");

        float b = 1f;

        print(b - 1);
        print(b--);
        print(b -= 1);
    }

    void Example8()
    {
        print("=== Example 8 ===");

        string a = "Happy ";
        string b = "Birthday";

        print(a + b);
    }

    void Example9() {
        print("=== Example 9 ===");

        string s = "I like ";
        int a = 77;

        print(s + a.ToString());
    }
}
