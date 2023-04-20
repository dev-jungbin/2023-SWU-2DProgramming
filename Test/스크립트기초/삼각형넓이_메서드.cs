using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspector13 : MonoBehaviour
{
    [SerializeField]
    public float bottom;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        print(GetTriangleArea(bottom, height));

    }

    // Update is called once per frame
    void Update()
    {

    }

    float GetTriangleArea(float b, float h)
    {
        print("=== 삼각형 넓이 메서드 ===");
        return b * h / 2;
    }
}
