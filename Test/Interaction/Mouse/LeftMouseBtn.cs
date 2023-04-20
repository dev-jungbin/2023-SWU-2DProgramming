using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMouseBtn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("좌측 버튼 눌렀음");
        }

        if (Input.GetMouseButtonUp(0))
        {
            print("좌측버튼떼었음");
        }
    }
}
