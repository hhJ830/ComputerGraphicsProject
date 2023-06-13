using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteScript : MonoBehaviour
{
    public Text collectedNote;
    public GameObject ss;
    public GameObject clickMessage;
    // Start is called before the first frame update

    void OnMouseDown()
    {
        if (ss != null)
            ss.SetActive(false);
        if (clickMessage != null)
            clickMessage.SetActive(false);
        int number = int.Parse(collectedNote.text) + 1;
        collectedNote.text = number.ToString();
    }

    void OnMouseOver()
    {
        if (clickMessage != null)
            clickMessage.SetActive(true);
    }

    void OnMouseExit()
    {
        if (clickMessage != null)
            clickMessage.SetActive(false);
    }
}
