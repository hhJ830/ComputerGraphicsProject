/*using UnityEngine;

public class ObjectClickHandler : MonoBehaviour
{
    public LayerMask clickMask; // 클릭을 감지할 레이어 마스크
    public GameObject objectToDisappear; // 사라질 오브젝트
    public float rotationSpeed = 50f; // 오브젝트의 회전 속도


    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 마우스 왼쪽 버튼이 클릭되면
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            //transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);

            /*
            if (gameObject == objectToDisappear) // 클릭된 오브젝트가 이 스크립트를 가진 오브젝트와 일치하는지 확인
            {
                transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
            }
            float rotationX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
            float rotationY = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;

            transform.Rotate(Vector3.up, -rotationX); // 오브젝트를 주어진 속도로 Y축 기준 회전
            transform.Rotate(Vector3.right, rotationY); // 오브젝트를 주어진 속도로 X축 기준 회전
            
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, clickMask))
            {
                if (hit.collider.gameObject == gameObject) // 클릭된 오브젝트가 이 스크립트를 가진 오브젝트와 일치하는지 확인
                { 
                    Debug.Log("Click event fired!");
                    objectToDisappear.SetActive(false); // 다른 오브젝트를 비활성화하여 사라지게 만듦

                    //float rotationX = rotationSpeed * Time.deltaTime;
                    //float rotationY = rotationSpeed * Time.deltaTime;
                    float rotationZ = rotationSpeed * Time.deltaTime;

                    //transform.Rotate(Vector3.right, rotationX); // X 축 회전
                    //transform.Rotate(Vector3.up, rotationY); // Y 축 회전
                    transform.Rotate(Vector3.forward, rotationZ); // Z 축 회전

                    //float rotationX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
                    //float rotationY = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;

                    //transform.Rotate(Vector3.up, -rotationX); // 오브젝트를 주어진 속도로 Y축 기준 회전
                    //transform.Rotate(Vector3.right, rotationY); // 오브젝트를 주어진 속도로 X축 기준 회전

                }
            }
        }
    }
}



using UnityEngine;

public class ObjectClickHandler : MonoBehaviour
{
    public LayerMask clickMask; // 클릭을 감지할 레이어 마스크
    public GameObject objectToDisappear; // 사라질 오브젝트
    public float rotationSpeed = 50f; // 오브젝트의 회전 속도

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 마우스 왼쪽 버튼이 클릭되면
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, clickMask))
            {
                if (hit.collider.gameObject == gameObject) // 클릭된 오브젝트가 이 스크립트를 가진 오브젝트와 일치하는지 확인
                {
                    Debug.Log("Click event fired!");
                    objectToDisappear.SetActive(false); // 다른 오브젝트를 비활성화하여 사라지게 만듦

                    float rotationX = rotationSpeed * Time.deltaTime;
                    float rotationY = rotationSpeed * Time.deltaTime;

                    transform.Rotate(Vector3.up, -rotationX); // 오브젝트를 주어진 속도로 Y축 기준 회전
                    transform.Rotate(Vector3.right, rotationY); // 오브젝트를 주어진 속도로 X축 기준 회전
                }
            }
        }
    }
}
*/

using UnityEngine;

public class ObjectClickHandler : MonoBehaviour
{
    public LayerMask clickMask; // 클릭을 감지할 레이어 마스크
    public GameObject objectToDisappear; // 사라질 오브젝트
    public float rotationSpeed = 50f; // 오브젝트의 회전 속도

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 마우스 왼쪽 버튼이 클릭되면
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, clickMask))
            {
                if (hit.collider.gameObject == gameObject) // 클릭된 오브젝트가 이 스크립트를 가진 오브젝트와 일치하는지 확인
                {
                    Debug.Log("Click event fired!");
                    objectToDisappear.SetActive(false); // 다른 오브젝트를 비활성화하여 사라지게 만듦

                    float rotationX = rotationSpeed * Time.deltaTime;
                    float rotationY = rotationSpeed * Time.deltaTime;

                    //transform.Rotate(Vector3.up, -rotationX); // 오브젝트를 주어진 속도로 Y축 기준 회전
                    //transform.Rotate(Vector3.right, rotationY); // 오브젝트를 주어진 속도로 X축 기준 회전
                    //transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime); // Z 축 회전

                    // 직접 회전을 적용합니다.
                    transform.rotation *= Quaternion.Euler(-rotationX, rotationY, 0f);
                }
            }
        }
    }
}
