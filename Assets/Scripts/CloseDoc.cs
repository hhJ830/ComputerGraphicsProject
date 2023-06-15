using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoc : MonoBehaviour
{
    public GameObject doc;
    // Start is called before the first frame update

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            doc.SetActive(false);

        }
    }
}
