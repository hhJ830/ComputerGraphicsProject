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
}