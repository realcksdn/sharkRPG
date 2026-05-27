using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameclear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // GameCounter.Instance를 통해 카운터 값을 직접 사용
    }

    // Update is called once per frame
    void Update()
    {
        // GameCounter.Instance를 직접 사용하여 카운터 값을 확인
        int currentValue = GameCounter.value;

        // 카운터 값에 따라 오브젝트 활성화/비활성화
        if (currentValue >= 10)
        {
            this.gameObject.SetActive(false); // 카운터 값이 10 이상일 때 비활성화
        }
        else
        {
            this.gameObject.SetActive(true); // 카운터 값이 10 이하일 때 활성화
        }
    }
}