using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TextChanger : MonoBehaviour
{
    public Text targetText; // 변화시킬 텍스트 컴포넌트
    public string[] texts = { "공중전화에 족보를 찾으라는 전화가 걸려왔다.", "홀린 듯 버려진 공학관에 들어왔는데 창문이 닫혀버렸다.", "망해따" }; // 변화할 글자들의 배열
    public float changeInterval = 3f; // 변화 간격 (초)

    private float timer = 0f;
    private int currentIndex = 0;

    private void Start()
    {
        if (targetText == null)
        {
            Debug.LogError("TextChanger: Target Text component is not assigned!");
            return;
        }

        // 첫번째 글자로 초기화
        targetText.text = texts[currentIndex];
    }

    private void Update()
    {
        timer += Time.deltaTime;

        // 일정 간격마다 글자 변경
        if (timer >= changeInterval)
        {
            currentIndex = (currentIndex + 1) % texts.Length; // 다음 인덱스 계산 (배열 범위를 벗어나면 처음으로 돌아감)
            targetText.text = texts[currentIndex]; // 글자 변경
            timer = 0f; // 타이머 초기화

            if(currentIndex==texts.Length-1)
            {
                SceneManager.LoadScene("SampleScene");

            }
        }
        
    }
}
