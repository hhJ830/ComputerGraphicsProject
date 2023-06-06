/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{

    public bool open = false;
    public float doorOpenAngle = 90f;
    public float doorCloseAngle = 0f;
    public float smoot = 2f;

    void Start()
    {

    }

    public void ChangeDoorState()
    {
        open = !open;
    }


    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.E))
        {
            open = !open;
        }

        if (open)
        {
            Quaternion targetRotation = Quaternion.Euler(0, doorOpenAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smoot * Time.deltaTime);
        }
        else
        {
            Quaternion targetRotation2 = Quaternion.Euler(0, doorCloseAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, smoot * Time.deltaTime);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool open = false;
    public float doorOpenAngle = 90f;
    public float doorCloseAngle = 0f;
    public float smooth = 2f;

    private Quaternion initialRotation;

    void Start()
    {
        initialRotation = transform.localRotation;
    }

    public void ChangeDoorState()
    {
        open = !open;
    }

    void Update()
    {
        Quaternion targetRotation;

        if (open)
        {
            targetRotation = Quaternion.Euler(0, doorOpenAngle, 0);
        }
        else
        {
            targetRotation = Quaternion.Euler(0, doorCloseAngle, 0);
        }

        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool open = false;
    public float doorOpenAngle = 90f;
    public float doorCloseAngle = 0f;
    public float smooth = 2f;

    private Quaternion initialRotation;

    void Start()
    {
        initialRotation = transform.localRotation;
    }

    public bool CanInteract()
    {
        return true; // 상호작용 가능 여부에 따른 추가 로직을 구현하려면 조건을 여기에 추가하세요.
    }

    public void Interact()
    {
        open = !open;
    }

    void Update()
    {
        Quaternion targetRotation;

        if (open)
        {
            targetRotation = Quaternion.Euler(0, doorOpenAngle, 0);
        }
        else
        {
            targetRotation = Quaternion.Euler(0, doorCloseAngle, 0);
        }

        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool open = false;
    public float doorOpenAngle = -90f; // 수정된 부분
    public float doorCloseAngle = 0f;
    public float smooth = 2f;

    private Quaternion initialRotation;

    void Start()
    {
        initialRotation = transform.localRotation;
    }

    public bool CanInteract()
    {
        return true;
    }

    public void Interact()
    {
        open = !open;
    }

    void Update()
    {
        Quaternion targetRotation;

        if (open)
        {
            targetRotation = Quaternion.Euler(0, doorOpenAngle, 0);
        }
        else
        {
            targetRotation = Quaternion.Euler(0, doorCloseAngle, 0);
        }

        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
    }
}
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool open = false;
    public float doorOpenAngle = -90f;
    public float doorCloseAngle = 0f;
    public float smooth = 2f;

    private Quaternion initialRotation;

    void Start()
    {
        initialRotation = transform.localRotation;
    }

    public void ToggleDoorState()
    {
        open = !open;
    }

    private void OnMouseDown()
    {
        if (CanInteract())
        {
            ToggleDoorState();
        }
    }

    public bool CanInteract()
    {
        return true; // 상호작용 가능 여부에 따른 추가 로직을 구현하려면 조건을 여기에 추가하세요.
    }

    void Update()
    {
        Quaternion targetRotation;

        if (open)
        {
            targetRotation = Quaternion.Euler(0, doorOpenAngle, 0);
        }
        else
        {
            targetRotation = Quaternion.Euler(0, doorCloseAngle, 0);
        }

        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
    }
}
