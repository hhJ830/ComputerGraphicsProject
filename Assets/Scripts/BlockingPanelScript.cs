using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockingPanelScript : MonoBehaviour
{
    public bool open = false;
    public GameObject keyObject;
    public GameObject message;
    public GameObject disappearObject;
 

    void messageOff()
    {
        message.SetActive(false);
    }

    private void OnMouseDown()
    {
        if (CanInteract())
        {
            disappearObject.SetActive(false);
        }
        else if (message != null)
        {
            message.SetActive(true);
            Invoke("messageOff", 2f);
        }
    }

    public bool CanInteract()
    {
        if (keyObject != null && keyObject.activeSelf == false)
        {
            return false;
        }
        else
            return true; // 상호작용 가능 여부에 따른 추가 로직을 구현하려면 조건을 여기에 추가하세요.
    }

}
