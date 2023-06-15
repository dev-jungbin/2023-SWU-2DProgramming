using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ResourceController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDrag()
    {
        // 마우스 위치 가져오기
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        // 이동할 오브젝트 위치 설정
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        // 이동
        transform.position = objPosition;
    }
}
