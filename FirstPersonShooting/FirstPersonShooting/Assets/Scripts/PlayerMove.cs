using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // 플레이어가 w, s, a, d를 이용해서 전후좌우로 이동시키고 싶다.
    // 필요요소 : 속력, 방향, 사용자의 입력
    public float moveSpeed = 7.0f;

    // 플레이어에게 중력을 적용하고 싶다.
    // 필요 요소: 중력의 크기, 중력의 방향
    public float gravity = -20.0f;

    // 사용자가 Space 키를 누르면 점프하고 싶다.
    // 단, 2회까지만 점프를 하고 싶다.    
    public float jumpPower = 30.0f;
    public int jumpCount = 2;

    CharacterController cc;
    float yVelocity = 0;


    float tongtong = 0;
    bool isJump = false;

    void Start()
    {
        cc = transform.GetComponent<CharacterController>();
        tongtong = jumpPower;
    }

    void LateUpdate()
    {
        // 사용자의 입력을 받는다.
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        #region 그냥 상하이동
        //float up = 0;
        //if(Input.GetKey(KeyCode.E))
        //{
        //    up = 1;
        //}
        //else if(Input.GetKeyDown(KeyCode.E))
        //{
        //    up = 0;
        //}

        //if (Input.GetKey(KeyCode.Q))
        //{
        //    up = -1;
        //}
        //else if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    up = 0;
        //}
        #endregion

        // 방향을 설정한다.
        Vector3 dir = new Vector3(h, 0, v);
        dir.Normalize();

        // 방향 벡터를 카메라의 방향을 기준으로 재계산한다.
        dir = Camera.main.transform.TransformDirection(dir);

        // 땅에 닿았으면 점프 횟수를 초기화한다.
        if (cc.collisionFlags == CollisionFlags.Below)
        {
            jumpCount = 2;

            // 통통 튕겨오르기
            if (isJump)
            {
                tongtong *= 0.6f;

                if (tongtong > 0.1f)
                {
                    yVelocity = tongtong;
                }
                else
                {
                    tongtong = jumpPower;
                    isJump = false;
                }
            }
        }

        // 사용자의 space 키 입력을 받는다.
        if (Input.GetButtonDown("Jump") && jumpCount > 0)
        {
            // 위쪽 방향으로의 힘(점프력)을 추가한다.
            //yVelocity = jumpPower;
            yVelocity = tongtong;
            jumpCount--;
            isJump = true;
        }

        // 중력 값을 적용한다.
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        // 입력된 방향으로 이동한다(p = p0 + vt).
        //transform.position += dir * moveSpeed * Time.deltaTime;
        cc.Move(dir * moveSpeed * Time.deltaTime);
    }
}
