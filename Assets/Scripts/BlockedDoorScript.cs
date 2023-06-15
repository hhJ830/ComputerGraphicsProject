using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockedDoorScript : MonoBehaviour
{
    public GameObject message;


    public void setMessageOff()
    {
        message.SetActive(false);
    }


    private void OnMouseDown()
    {
         message.SetActive(true);
         Invoke("setMessageOff", 2);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
