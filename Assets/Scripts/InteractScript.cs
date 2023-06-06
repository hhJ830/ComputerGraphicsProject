/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InteractScript : MonoBehaviour
{

    public float interactDiastance = 5f;
    public DoorScript doorScript;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            doorScript.ChangeDoorState();

            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, interactDiastance))
            {
                if (hit.collider.CompareTag("Door"))
                {
                    hit.collider.transform.parent.GetComponent<DoorScript>().ChangeDoorState();
                }
            }
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript : MonoBehaviour
{
    public float interactDistance = 5f;
    public DoorScript doorScript;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (doorScript != null)
            {
                doorScript.ChangeDoorState();
            }
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript : MonoBehaviour
{
    public float interactDistance = 5f;
    public LayerMask interactLayer;
    private DoorScript currentDoor;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            Ray ray = new Ray(transform.position, transform.forward);

            if (Physics.Raycast(ray, out hit, interactDistance, interactLayer))
            {
                currentDoor = hit.collider.GetComponent<DoorScript>();

                if (currentDoor != null)
                {
                    currentDoor.ChangeDoorState();
                }
            }
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript : MonoBehaviour
{
    public float interactDistance = 5f;
    public LayerMask interactLayer;
    private DoorScript currentDoor;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (currentDoor != null && currentDoor.CanInteract())
            {
                currentDoor.Interact();
            }
        }
    }

    void FixedUpdate()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(ray, out hit, interactDistance, interactLayer))
        {
            currentDoor = hit.collider.GetComponent<DoorScript>();
        }
        else
        {
            currentDoor = null;
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript : MonoBehaviour
{
    public float interactDistance = 5f;
    public LayerMask interactLayer;
    private DoorScript currentDoor;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (currentDoor != null && currentDoor.CanInteract())
            {
                currentDoor.Interact();
            }
        }
    }

    void FixedUpdate()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(ray, out hit, interactDistance, interactLayer))
        {
            currentDoor = hit.collider.GetComponent<DoorScript>();
        }
        else
        {
            currentDoor = null;
        }
    }
}*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript : MonoBehaviour
{
    public float interactDistance = 5f;
    public LayerMask interactLayer;
    private DoorScript currentDoor;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 마우스 왼쪽 버튼을 클릭할 때
        {
            if (currentDoor != null && currentDoor.CanInteract())
            {
                currentDoor.ToggleDoorState();
            }
        }
    }

    void FixedUpdate()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, interactDistance, interactLayer))
        {
            currentDoor = hit.collider.GetComponent<DoorScript>();
        }
        else
        {
            currentDoor = null;
        }
    }
}

