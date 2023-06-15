using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PasswordScript : MonoBehaviour
{
    public GameObject passwordScreen;
    public GameObject keyItem;
    public TMP_InputField passwordInput;
    public string password;

    // Start is called before the first frame update
    void Start()
    {
        passwordInput.Select();
    }

    // Update is called once per frame
    void Update()
    {
        unlock();
    }
    public void unlock()
    {
        if (passwordInput.text == password)
        {
            keyItem.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space))
            passwordScreen.SetActive(false);
    }
}
