using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cond : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("=== Cond Start ===");
        bool isTrue = true;

        if (isTrue) {
            print("참");
        }

        IfElseExample0();
        IfExample0();
        IfElseExample1();
        IfExample1();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void IfElseExample0() {
        print("=== If-Else 0 ===");
        bool isTrue = true;

        if (isTrue) {
            print("참");
        } else {
            print("거짓");
        }
    }

    void IfExample0() {
        print("=== If 0 ===");
        int n = 1;
        
        if (n == 1) {
            print("체력 회복");
        }
    }

    void IfElseExample1() {
        print("=== If-Else 1 ===");
        int hp = 80;

        if (hp >= 100) {
            print("공격");
        } else {
            print("방어");
        }
    }

    void IfExample1() {
        print("=== If 1 ===");
        float num = 72f;

        if (num >= 90) {
            print("A");
        } else if (num >= 80) {
            print("B");
        } else if (num >= 70) {
            print("C");
        } else {
            print("F");
        }
    }
}
