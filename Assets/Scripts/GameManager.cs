using UnityEngine;
using TMPro; // TextMeshPro를 사용하려면 필요

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI counterText; // UI 텍스트 연결

    void Start()
    {
        if (counterText == null)
        {
            Debug.LogError("CounterText is not assigned in the inspector.");
        }

        // 카운터 텍스트 초기화
        UpdateCounterText();
    }

    void Update()
    {
        // GameCounter.value를 텍스트로 변환하여 표시
        UpdateCounterText();
    }

    void UpdateCounterText()
    {
        if (counterText != null)
        {
            counterText.text = "Counter: " + GameCounter.value.ToString();
        }
    }
}
