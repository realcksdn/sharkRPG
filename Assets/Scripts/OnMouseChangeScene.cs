using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OnMouseChangeScene : MonoBehaviour
{
   
    private int currentCounterValue; // GameCounter에서 값 읽어올 변수

    // Start is called before the first frame update
    void Start()
    {
        // GameCounter의 카운터 값으로 초기화
        currentCounterValue = GameCounter.value;
    }

    // Update is called once per frame
    void Update()
    {
        // GameCounter의 카운터 값을 매 프레임마다 가져와 사용
        currentCounterValue = GameCounter.value;

        // 카운터 값이 10 이상일 때 오브젝트 활성화, 그 외에는 비활성화
        if (currentCounterValue >= 10)
        {
            this.gameObject.SetActive(true);
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        // 페이드 스크립트 호출 (씬 전환 전에 페이드 효과)
        SceneManager.LoadScene("clearScene");

        // 페이드 후 씬 전환
        
    }
}

