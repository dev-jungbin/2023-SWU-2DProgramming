using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;

public class Method : MonoBehaviour
{
    string str = "안녕";
    int num = 2;
    float val = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        print("=== 메서드 생성(문자열) ===");
        ShowStr();
        SetStr("코딩");

        string s1 = GetStr();
        print(s1);

        string s2 = AddStr("수업");
        print(s2);

        print("=== 메서드 생성(정수형) ===");
        ShowNum();
        SetNum(5);
        print("SetNum: " + num);

        int num1 = GetNum();
        print("GetNum: " + num1);;

        int num2 = AddNum(3);
        print("AddNum: " + num2);

        print("=== 메서드 생성(실수형) ===");
        ShowVal();
        SetVal(3.2f);
        print("SetVal: " + val);

        float val1 = GetVal();
        print("GetVal: " + val1);;

        float val2 = AddVal(1.2f);
        print("AddVal: " + val2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // 메서드 생성(문자열)

    void ShowStr() {
        print(str);
    }

    void SetStr(string s) {
        str = s;
    }

    string GetStr() {
        return str;
    }

    string AddStr(string s) {
        return str + s;
    }

    // 메서드 생성(정수형)

    void ShowNum() {
        print(num);
    }

    void SetNum(int newNum) {
        num = newNum;
    }

    int GetNum() {
        return num;
    }

    int AddNum(int plusNum) {
        return num + plusNum;
    }

    // 메서드 생성(실수형)

    void ShowVal() {
        print(val);
    }

    void SetVal(float newVal) {
        val = newVal;
    }

    float GetVal() {
        return val;
    }

    float AddVal(float plusVal) {
        return val + plusVal;
    }
}
