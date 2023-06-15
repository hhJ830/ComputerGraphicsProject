using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    [SerializeField]
    private GameObject howtoPlayManual;

    [SerializeField]
    private Button startButton, howToPlayButton, quitButton, manualExitButton;




// Start is called before the first frame update
void Start()
    {
        startButton.onClick.AddListener(OnclickStartButton);
        howToPlayButton.onClick.AddListener(OpenManual);
        quitButton.onClick.AddListener(OnclickQuitButton);
        manualExitButton.onClick.AddListener(CloseManual);

        if (howtoPlayManual.activeSelf == true)
            howtoPlayManual.gameObject.SetActive(false);
    }

    private void OnclickStartButton()
    {
        SceneManager.LoadScene("GameStartScene");
    }
    private void OnclickQuitButton()
    {
        Application.Quit(); //프로그램 종료
    }


    public void OpenManual()
    {
        if (howtoPlayManual.gameObject.activeSelf == false)
        {
            howtoPlayManual.gameObject.SetActive(true);
            startButton.enabled = false;
            howToPlayButton.enabled = false;
            quitButton.enabled = false;
        }
    }
    public void CloseManual()
    {
        if (howtoPlayManual.gameObject.activeSelf == true)
        {
            howtoPlayManual.gameObject.SetActive(false);
            startButton.enabled = true;
            howToPlayButton.enabled = true;
            quitButton.enabled = true;
        }
    }
}