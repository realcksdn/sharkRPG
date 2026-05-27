using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCounter : MonoBehaviour
{
    public static GameCounter Instance;
    public static int value; // 공유하는 카운터의 값

    public int startCount = 0; // 카운터 초깃값 : Inspector에 지정

    void Awake()
    {
        // 싱글턴 패턴 적용
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // 오브젝트를 씬 변경 시 유지
            value = startCount; // 카운터 값 초기화
        }
        else
        {
            // 중복된 오브젝트가 있을 경우 제거
            Destroy(gameObject); // 이미 존재하는 GameCounter 오브젝트는 파괴
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            value = 10;
        }
    }
}
