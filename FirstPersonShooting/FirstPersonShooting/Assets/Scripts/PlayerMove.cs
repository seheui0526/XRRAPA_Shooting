using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // �÷��̾ w, s, a, d�� �̿��ؼ� �����¿�� �̵���Ű�� �ʹ�.
    // �ʿ��� : �ӷ�, ����, ������� �Է�
    public float moveSpeed = 7.0f;

    // �÷��̾�� �߷��� �����ϰ� �ʹ�.
    // �ʿ� ���: �߷��� ũ��, �߷��� ����
    public float gravity = -20.0f;

    // ����ڰ� Space Ű�� ������ �����ϰ� �ʹ�.
    // ��, 2ȸ������ ������ �ϰ� �ʹ�.    
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
        // ������� �Է��� �޴´�.
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        #region �׳� �����̵�
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

        // ������ �����Ѵ�.
        Vector3 dir = new Vector3(h, 0, v);
        dir.Normalize();

        // ���� ���͸� ī�޶��� ������ �������� �����Ѵ�.
        dir = Camera.main.transform.TransformDirection(dir);

        // ���� ������� ���� Ƚ���� �ʱ�ȭ�Ѵ�.
        if (cc.collisionFlags == CollisionFlags.Below)
        {
            jumpCount = 2;

            // ���� ƨ�ܿ�����
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

        // ������� space Ű �Է��� �޴´�.
        if (Input.GetButtonDown("Jump") && jumpCount > 0)
        {
            // ���� ���������� ��(������)�� �߰��Ѵ�.
            //yVelocity = jumpPower;
            yVelocity = tongtong;
            jumpCount--;
            isJump = true;
        }

        // �߷� ���� �����Ѵ�.
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        // �Էµ� �������� �̵��Ѵ�(p = p0 + vt).
        //transform.position += dir * moveSpeed * Time.deltaTime;
        cc.Move(dir * moveSpeed * Time.deltaTime);
    }
}
