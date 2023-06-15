using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMemoController : MonoBehaviour
{
    GameObject memo;
    // Start is called before the first frame update
    void Start()
    {
        // memo 오브젝트 가져오기
        memo = GameObject.Find("memo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        // 만약 메모 오브젝트가 안 보이는 투명 상태라면
        if (memo.GetComponent<SpriteRenderer>().color == Color.clear)
        {
            // 메모 오브젝트 보여주기
            memo.GetComponent<SpriteRenderer>().color = Color.white;
        }
        else // 만약 메모 오브젝트가 보이는 상태라면
        {
            // 메모 오브젝트 숨기기(투명화)
            memo.GetComponent<SpriteRenderer>().color = Color.clear;
        }
        
    }
}
