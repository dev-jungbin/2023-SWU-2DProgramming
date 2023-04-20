using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspector6 : MonoBehaviour
{
    [SerializeField]
    public Vector2 v1;
    public Vector2 v2;

    // Start is called before the first frame update
    void Start()
    {
        print("=== 벡터의 사칙연산 ===");

        print(v1 + v2);
        print(v1 - v2);
        print(v1 * v2);
        print(v1 / v2);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
