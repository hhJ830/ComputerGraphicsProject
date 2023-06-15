using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpscareWindowScript : MonoBehaviour
{
    public GameObject warningmessage;
    public GameObject jumpscare;
    bool isOver;
    float overTime = 0;

    void Start()
    {
        isOver = false;
        overTime = 0;
    } 

    void OnMouseOver()
    {
        isOver = true;
    }

    void OnMouseExit()
    {
        isOver = false;
    }

    void offMessage()
    {
        warningmessage.SetActive(false);
    }

    void offJumpScare()
    {
        jumpscare.SetActive(false);
    }

    private void Update()
    {
        if (isOver)
        {
            overTime++;
            if (overTime == 1500)
            {
                warningmessage.SetActive(true);
                Invoke("offMessage", 2);
            }
            if (overTime == 4000)
            {
                jumpscare.SetActive(true);
                Invoke("offJumpScare", 2);
            }
        }
    }

}
