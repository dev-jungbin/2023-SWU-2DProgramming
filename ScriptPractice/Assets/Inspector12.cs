using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspector12 : MonoBehaviour
{
    [SerializeField]
    public float radius;

    // Start is called before the first frame update
    void Start()
    {
        print(GetCircleArea(radius));

    }

    // Update is called once per frame
    void Update()
    {

    }

    float GetCircleArea(float r)
    {
        print("=== 원의 넓이 메서드 ===");
        return 3.141592f * r * r;
    }
}
