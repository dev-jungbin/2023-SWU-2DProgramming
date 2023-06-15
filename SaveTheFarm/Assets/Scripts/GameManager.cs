using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int homeHP = 100;
    public int currentLevel = 1;
    public int power = 1;
    public float speed = 1f;

    public Vector3 originPowerFruitPosition;
    public Vector3 originSpeedFruitPosition;
    public Vector3 originSoupPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 게임 실패 시 호출
    public void GameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }

    // 게임 성공 시 호출
    public void GameClear()
    {
        SceneManager.LoadScene("GameClearScene");
    }

    public void ResetGameManager()
    {
        // 게임매니저의 프로퍼티들을 초기화
        homeHP = 100;
        currentLevel = 1;
        power = 1;
        speed = 1f;
    }

    public void LoadNewGame()
    {
        ResetGameManager();
        SceneManager.LoadScene("IntroScene");
    }
}
