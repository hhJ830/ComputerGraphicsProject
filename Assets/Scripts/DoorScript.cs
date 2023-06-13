
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{
    public GameObject keyItem;
    public GameObject message;
    public bool open = false;
    public float doorOpenAngle = -90f;
    public float doorCloseAngle = 0f;
    public float smooth = 1f;

    private Quaternion initialRotation;

    void Start()
    {
        initialRotation = transform.localRotation;
    }

    public void ToggleDoorState()
    {
        open = !open;
    }

    public void setMessageOff()
    {
        message.SetActive(false);
    }
    

    private void OnMouseDown()
    {
        if (CanInteract())
        {
            ToggleDoorState();
        }
        else
        {
            message.SetActive(true);
            Invoke("setMessageOff", 2);
        }
    }

    public bool CanInteract()
    {
        if (keyItem.activeSelf)
            return true;
        else
            return false;
         // 상호작용 가능 여부에 따른 추가 로직을 구현하려면 조건을 여기에 추가하세요.
    }

    void Update()
    {
        Quaternion targetRotation;

        if (open)
        {
            targetRotation = Quaternion.Euler(0, doorOpenAngle, 0);
        }
        else
        {
            targetRotation = Quaternion.Euler(0, doorCloseAngle, 0);
        }

        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
    }
}
