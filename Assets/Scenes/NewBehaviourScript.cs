using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody.AddForce(0, 500, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
