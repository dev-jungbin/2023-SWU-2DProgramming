using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjActWithMouse : MonoBehaviour
{
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            obj.SetActive(true);
            print("���� ��ư: " + obj.activeSelf);
        }

        if (Input.GetMouseButtonUp(1))
        {
            obj.SetActive(false);
            print("���� ��ư: " + obj.activeSelf);
        }
    }
}
