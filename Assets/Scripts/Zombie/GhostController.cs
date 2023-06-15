
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GhostController : MonoBehaviour
{
    public Transform[] patrolPoints; // 순찰 지점들의 위치 정보를 담는 배열
    public float patrolSpeed = 3f; // 순찰 속도
    public float detectionRange = 1f; // 플레이어 감지 범위

    private Transform player; // 플레이어의 위치 정보
    private int currentPatrolIndex = 0; // 현재 순찰 지점의 인덱스
    private bool isChasing = false; // 추격 상태인지 여부

    //public UnityEngine.UI.Image gameOverImage; //게임오버 이미지
    
    //public UnityEngine.UI.Text gameOverText; // 게임 오버 텍스트

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //GameManager.Instance.SetGameOverText(gameOverText);

        //gameOverText = GameObject.Find("GameOverText").GetComponent<UnityEngine.UI.Text>(); // 수정된 부분

        //gameOverImage.sprite = Resources.Load<Sprite>("GameOverImage");

        //gameOverImage.gameObject.SetActive(false); //게임오버 이미지 비활성화
        //gameOverText.gameObject.SetActive(false); // 게임 오버 텍스트 비활성화

    }

    private void Update()
    {
        if (isChasing)
        {
            ChasePlayer();
        }
        else
        {
            Patrol();
            CheckDetection();
        }
    }

    private void Patrol()
    {
        Vector3 targetPosition = patrolPoints[currentPatrolIndex].position;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, patrolSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
            if (currentPatrolIndex == 0 || currentPatrolIndex == patrolPoints.Length - 1)
            {
                // 양끝 지점에 도달하면 180도 회전
                transform.Rotate(new Vector3(0, 180, 0));
            }
        }
    }

    private void CheckDetection()
    {
        if (Vector3.Distance(transform.position, player.position) < detectionRange)
        {
            Debug.Log("Player detected! Game over.");
            // 게임 오버 처리 로직 추가
            GameOver();

        }
    }

    private void ChasePlayer()
    {
        // 플레이어를 추격하는 동작 구현
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 플레이어와 충돌했을 때 게임 오버 처리
            GameOver();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // 플레이어와 충돌했을 때 게임 오버 처리
            GameOver();
        }
    }
    private void GameOver()
    {
        Debug.Log("Game Over!");
        // 게임 오버 처리 로직을 여기에 추가하세요.
        //gameOverText.gameObject.SetActive(true);

        //gameOverImage.gameObject.SetActive(true);
        //GameManager.Instance.GameOver(gameOverText);

        //GameManager.Instance.GameOver();

        SceneManager.LoadScene("GameOverScene"); // GameOverScene으로 전환

        //GameManager.Instance.SetGameOverText(gameOverText.text); // GameOverText 설정
        // 화면 밝기를 조절하는 코드 추가
        RenderSettings.ambientIntensity = 0.2f; // 환경 조명의 강도를 낮춥니다.
        RenderSettings.reflectionIntensity = 0.2f; // 반사 강도를 낮춥니다.

    }

    // 기타 필요한 함수 및 코드 추가 가능
}
