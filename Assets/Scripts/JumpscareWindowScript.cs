using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpscareWindowScript : MonoBehaviour
{
    public GameObject message;
    float overTime = 0;

    void Start()
    {
        overTime = 0;
    } 

    void setMessageOff()
    {
        message.SetActive(false);
    }
    
    /*
    private void OnMouseEnter()
    {
        overTime += 1;
        if (overTime == 1)
        {
            message.SetActive(true);
            Invoke("setMessageOff", 2);
        }
    }
    */

    private void OnMouseDown()
    {
        message.SetActive(true);
        Invoke("setMessageOff", 2);
    }

}
