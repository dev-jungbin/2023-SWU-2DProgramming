using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("=== 초기화 & 대입 ===");
        Student swu1 = new Student();
        swu1.Show();

        Student swu2 = new Student();
        swu2.Show();

        print("=== 클래스 생성(문자열) ===");
        StrClass myStr = new StrClass();
        myStr.ShowStr();
        myStr.SetStr("코딩");

        string s1 = myStr.GetStr();
        print(s1);

        string s2 = myStr.AddStr("수업");
        print(s2);

        print("=== 클래스 생성(정수형) ===");
        NumClass myNum = new NumClass();
        myNum.ShowNum();
        myNum.SetNum(5);
        print("after SetNum: " + myNum.GetNum());

        int num1 = myNum.GetNum();
        print("GetNum: " + num1);;

        int num2 = myNum.AddNum(3);
        print("AddNum: " + num2);
        
        print("=== 클래스 생성(실수형) ===");
        ValClass myVal = new ValClass();
        myVal.ShowVal();
        myVal.SetVal(3.2f);
        print("after SetVal: " + myVal.GetVal());

        float val1 = myVal.GetVal();
        print("GetVal: " + val1);;

        float val2 = myVal.AddVal(1.2f);
        print("AddVal: " + val2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Student {
    string name = "슈니";

    public void Show() {
        Debug.Log(name);
    }
}

public class StrClass {
    string str = "안녕";

    public void ShowStr() {
        Debug.Log(str);
    }

    public void SetStr(string s) {
        str = s;
    }

    public string GetStr() {
        return str;
    }

    public string AddStr(string s) {
        return str + s;
    }
}

public class NumClass {
    int num = 2;

    public void ShowNum() {
        Debug.Log(num);
    }

    public void SetNum(int newNum) {
        num = newNum;
    }

    public int GetNum() {
        return num;
    }

    public int AddNum(int plusNum) {
        return num + plusNum;
    }
}

public class ValClass {
    float val = 1.5f;

    public void ShowVal() {
        Debug.Log(val);
    }

    public void SetVal(float newVal) {
        val = newVal;
    }

    public float GetVal() {
        return val;
    }

    public float AddVal(float plusVal) {
        return val + plusVal;
    }
}