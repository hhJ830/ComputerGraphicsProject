/*using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
                if (instance == null)
                {
                    GameObject managerObject = new GameObject("GameManager");
                    instance = managerObject.AddComponent<GameManager>();
                    DontDestroyOnLoad(managerObject);
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    public void GameOver()
    {
        // 게임 오버 시 게임 오버 씬으로 전환하는 로직 추가
        SceneManager.LoadScene("GameOverScene");
    }

    public void PlayAgain()
    {
        // 게임하기 버튼을 눌렀을 때 호출되는 함수
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        // 종료 버튼을 눌렀을 때 호출되는 함수
        Application.Quit();
    }
}
*/
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
    // 싱글톤 패턴 구현
    private static GameManager _instance;
    //public static GameManager Instance { get { return _instance; } }
    //public static GameManager Instance { get; private set; }
    public static GameManager Instance;
   
    public Text gameOverText;


    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // ...
    /*
    public void GameOver(string text)
    {
        Debug.Log("Game Over!");
        // 게임 오버 처리 로직을 여기에 추가하세요.
        gameOverText.text = text;
        //gameOverText.gameObject.SetActive(true);

        // 게임오버 시 게임 오버 씬으로 전환
        SceneManager.LoadScene("GameOverScene");

        // 화면 밝기를 조절하는 코드 추가
        RenderSettings.ambientIntensity = 0.2f; // 환경 조명의 강도를 낮춥니다.
        RenderSettings.reflectionIntensity = 0.2f; // 반사 강도를 낮춥니다.
    }*/
    public void GameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }
    /*
    public void PlayAgain()
    {
        // 게임하기 버튼을 눌렀을 때 호출되는 함수
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        // 종료 버튼을 눌렀을 때 호출되는 함수
        Application.Quit();
    }*/
    /*public void SetGameOverText(String text)
    {
        gameOverText.text = text;
    }
    public Text GetGameOverText()
    {
        return gameOverText;
    }*/

    // ...
}
