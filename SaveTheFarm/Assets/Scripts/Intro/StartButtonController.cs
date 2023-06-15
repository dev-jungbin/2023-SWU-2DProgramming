using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonController : MonoBehaviour
{
    private void Awake()
    {
        // GameManager 오브젝트 불러오기
        GameObject gameManager = GameObject.Find("GameManager");

        // 씬이 넘어가도 전역으로 Game manager를 쓸 수 있도록 구현
        DontDestroyOnLoad(gameManager);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    // 마우스 클릭되면
    private void OnMouseDown()
    {
        // 첫 번째 씬으로 전환
        SceneManager.LoadScene("DayScene");
    }
}
