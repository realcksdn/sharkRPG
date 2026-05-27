using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 충돌하면 카운터를 증가한다 
public class OnCollision_Count : MonoBehaviour
{
    public GameObject targetObjectName; // 목표 오브젝트 : Inspector에 지정
    public int addValue = 1;            // 증가량 : Inspector에 지정

    void OnCollisionEnter2D(Collision2D collision) // 충돌하면
    {
        // 만약 충돌한 오브젝트가 목표 오브젝트와 같다면
        if (collision.gameObject == targetObjectName)
        {
            // 카운터 값을 증가한다 
            GameCounter.value += addValue;
            

        }
    }
}
