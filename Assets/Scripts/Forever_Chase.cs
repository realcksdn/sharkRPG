using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 씬 관리를 위해 추가

// 계속 뒤쫓아 간다
public class Forever_Chase : MonoBehaviour
{
    public string targetObjectName; // 목표 오브젝트 이름 : Inspector에 지정
    public string sceneToLoad; // 이동할 씬 이름 : Inspector에 지정
    public float speed = 1; // 속도：Inspector에 지정

    private GameObject targetObject;
    private Rigidbody2D rbody;

    void Start()
    {
        // 목표 오브젝트를 찾아낸다
        targetObject = GameObject.Find(targetObjectName);

        if (targetObject == null)
        {
            Debug.LogError("Target object not found. Check the targetObjectName in the Inspector.");
            return;
        }

        // Rigidbody2D 설정
        rbody = GetComponent<Rigidbody2D>();
        if (rbody == null)
        {
            Debug.LogError("Rigidbody2D component not found on this object.");
            return;
        }

        // 중력을 0으로 해서 충돌 시에 회전시키지 않는다
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void FixedUpdate()
    {
        if (targetObject == null) return;

        // 목표 오브젝트의 방향을 조사해서
        Vector3 dir = (targetObject.transform.position - this.transform.position).normalized;
        // 그 방향에 지정한 양으로 나아간다
        float vx = dir.x * speed;
        float vy = dir.y * speed;
        rbody.velocity = new Vector2(vx, vy);

        // 이동 방향에서 왼쪽 오른쪽으로 방향을 바꾼다
        this.GetComponent<SpriteRenderer>().flipX = (vx < 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 목표 오브젝트와 충돌하면 씬 이동
        if (collision.gameObject == targetObject)
        {
            Debug.Log("Collided with target object. Loading scene: " + sceneToLoad);
            SceneManager.LoadScene(sceneToLoad); // 씬 이동
        }
    }
}
