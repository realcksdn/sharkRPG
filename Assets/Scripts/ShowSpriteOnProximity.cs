using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSpriteOnTrigger : MonoBehaviour
{
    public GameObject targetSpriteObject;  // 활성화/비활성화할 스프라이트 오브젝트
    public GameObject player;  // 플레이어 오브젝트 (Inspector에서 연결)

    void Start()
    {
        if (player == null)
        {
            Debug.LogError("플레이어 오브젝트가 설정되지 않았습니다! Inspector에서 플레이어를 연결하세요.");
            return;
        }

        if (targetSpriteObject == null)
        {
            Debug.LogError("타겟 스프라이트 오브젝트가 설정되지 않았습니다!");
            return;
        }

        targetSpriteObject.SetActive(true);  // 시작 시 스프라이트 비활성화
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log($"OnTriggerEnter2D: {other.gameObject.name}");
        if (other.gameObject == player)
        {
            Debug.Log("플레이어가 2D Trigger에 들어왔습니다.");
            targetSpriteObject.SetActive(true);
            
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log($"OnTriggerExit2D: {other.gameObject.name}");
        if (other.gameObject == player)
        {
            Debug.Log("플레이어가 2D Trigger에서 나갔습니다.");
            targetSpriteObject.SetActive(false);
     
        }
    }
   
}

