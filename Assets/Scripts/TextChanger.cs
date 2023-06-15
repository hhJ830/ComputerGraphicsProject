using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TextChanger : MonoBehaviour
{
    public Text targetText; // 변화시킬 텍스트 컴포넌트
    public string[] texts = { "시험 공부를 하고 집에 돌아가던 중, 갑자기 내 옆에 있던 공중전화에서 벨소리가 들려왔다.", 
        "나는 아무 생각 없이 전화를 받았고, 전화 속의 목소리는 내게 '폐 공학관에 들어가면 족보를 찾을 수 있다'고 말했다.", 
        "그 말을 듣고 열려 있던 창문을 통해 안으로 들어갔지만, 이내 창문이 닫히고 말았다.",
    "여기서 나가야만 한다."}; // 변화할 글자들의 배열
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
        if (currentIndex == texts.Length - 1)
            changeInterval *= 2;

        // 일정 간격마다 글자 변경
        if (timer >= changeInterval)
        {
            currentIndex = (currentIndex + 1) % texts.Length; // 다음 인덱스 계산 (배열 범위를 벗어나면 처음으로 돌아감)
            targetText.text = texts[currentIndex]; // 글자 변경
            timer = 0f; // 타이머 초기화

            if(currentIndex==texts.Length-1)
            {
                SceneManager.LoadScene("InGameScene");

            }
        }
        
    }
}
