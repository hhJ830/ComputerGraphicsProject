using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverSceneController : MonoBehaviour
{
    public Text gameOverText;
    public Button returnButton;
    public Button exitButton;

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        // 초기화
        //gameOverText.gameObject.SetActive(false);

        // 돌아가기 버튼 클릭 이벤트
        returnButton.onClick.AddListener(ReturnToGame);

        // 종료 버튼 클릭 이벤트
        exitButton.onClick.AddListener(ExitGame);
    }

    private void ReturnToGame()
    {
        SceneManager.LoadScene("InGameScene");
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}
