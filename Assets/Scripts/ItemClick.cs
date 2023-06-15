using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemClick : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ss;
    public GameObject inventoryss;
    public GameObject clickMessage;
    public GameObject doc;
    public bool isRotate;
    bool isClicked;
    int count = 0;
    public float degreePerSecond;

    void Start()
    {
        isClicked = false;
    }
    void OnMouseDown()
    {
        if (ss != null)
            ss.SetActive(false);
        if (inventoryss != null)
            inventoryss.SetActive(true);
        if (clickMessage != null)
            clickMessage.SetActive(false);
        if (doc != null)
            doc.SetActive(true);
        isClicked = true;
    }

    void OnMouseOver()
    {
        if(clickMessage != null)
            clickMessage.SetActive(true);
    }
    
    void OnMouseExit()
    {
        if (clickMessage != null)
            clickMessage.SetActive(false);
    }

    private void Update()
    {
        if (isRotate == true && isClicked == true)
        {
            count++;
            transform.Rotate(Vector3.up * Time.deltaTime * degreePerSecond);

            if (count == 1000)
                isRotate = false;
        }
    }
}