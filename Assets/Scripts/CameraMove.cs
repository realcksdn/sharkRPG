using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float minY = 0f;  // Y축 최소값
    public float maxY = 10f; // Y축 최대값
    public float minX = -30f;  // Y축 최소값
    public float maxX = 30f; // Y축 최대값
    public Transform player; // 플레이어의 Transform
    public Vector3 offset;   // 카메라와 플레이어 사이의 거리 (오프셋)
    public float smoothSpeed = 0.125f;

    void Update()
    {
        Vector3 cameraPosition = transform.position;

        // Y축 값을 제한
        cameraPosition.y = Mathf.Clamp(cameraPosition.y, minY, maxY);
        cameraPosition.x = Mathf.Clamp(cameraPosition.x, minX, maxX);

        // 제한된 위치를 카메라에 적용
        transform.position = cameraPosition;
    }
    void LateUpdate()
    {
        if (player != null)
        {
            Vector3 targetPosition = player.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);
        }
    }
}
