using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainDoorScript : MonoBehaviour
{
    public bool open = false;
    public float doorOpenAngle = -90f;
    public float doorCloseAngle = 0f;
    public float smooth = 2f;
    public GameObject keyObject1;
    public GameObject keyObject2;
    public GameObject keyObject3;
    public GameObject message;
    public Text collectedNote;
    AudioSource audioSource;


    private Quaternion initialRotation;

    void Start()
    {
        initialRotation = transform.localRotation;
        audioSource = GetComponent<AudioSource>();
    }

    public void ToggleDoorState()
    {
        open = !open;
    }

    void gotoEnding()
    {
        int number = int.Parse(collectedNote.text);
        if (number == 4)
        {
            SceneManager.LoadScene("GoodEndingScene");
        }
        else
        {
            SceneManager.LoadScene("BadEndingScene");
        }
    }

    private void OnMouseDown()
    {
        if (CanInteract())
        {
            audioSource.Play();
            ToggleDoorState();
        }
    }

    public bool CanInteract()
    {
        if (!keyObject1.activeSelf && !keyObject2.activeSelf && !keyObject3.activeSelf)
        {
            return true;
        }
        else
            return false; // 상호작용 가능 여부에 따른 추가 로직을 구현하려면 조건을 여기에 추가하세요.
    }

    void Update()
    {
        Quaternion targetRotation;

        if (open)
        {
            targetRotation = Quaternion.Euler(0, doorOpenAngle, 0);
            Invoke("gotoEnding", 3f);
        }
        else
        {
            targetRotation = Quaternion.Euler(0, doorCloseAngle, 0);
        }

        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
    }
}
