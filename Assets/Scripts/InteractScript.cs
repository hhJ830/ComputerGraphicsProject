
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

