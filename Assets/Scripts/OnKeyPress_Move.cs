using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 키를 누르면 이동한다
public class OnKeyPress_Move : MonoBehaviour
{

    public float speed = 2; // 속도：Inspector에 지정

    float vx = 0;
    float vy = 0;
    bool leftFlag = false;
    Rigidbody2D rbody;

    void Start()
    { 
      // 중력을 0으로 해서 충돌 시에 회전시키지 않는다
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void Update()
    { 
        vx = 0;
        vy = 0;
        if (Input.GetKey("right"))
        { 
            vx = speed; 
            leftFlag = true;
        }
        if (Input.GetKey("left"))
        { 
            vx = -speed; 
            leftFlag = false;
        }
        if (Input.GetKey("up"))
        { 
            vy = speed; 
        }
        if (Input.GetKey("down"))
        { 
            vy = -speed;  
        }
    }
    void FixedUpdate()
    { 
        rbody.velocity = new Vector2(vx, vy);
        
        this.GetComponent<SpriteRenderer>().flipX = leftFlag;
    }
}
