using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    // ������� ���콺 �巡�� �Է��� �޾Ƽ� ĳ���͸� �����¿�� ȸ����Ű�� �ʹ�!
    // �ʿ� ���: ���콺 �巡�� �Է�, ȸ���� ����(��), ȸ�� �ӷ�
    public float rotSpeed = 10.0f;

    public bool rotateX = false;
    public bool rotateY = false;

    float rotX = 0;
    float rotY = 0;

    void Start()
    {

    }

    void Update()
    {
        // ���콺�� �巡�� ���� �Է��� �޴´�.
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        #region �ǽð� ȸ�� ��� ���
        //// �Է��� �������� ȸ���� ������ �����Ѵ�.
        //Vector3 dir = new Vector3(-y, x, 0);
        //dir.Normalize();

        //// ȸ�� �������� ȸ���Ѵ�.(r = r0 + vt)
        //transform.eulerAngles += dir * rotSpeed * Time.deltaTime;

        //// x�� ȸ�� ���� ���� 60�� ������ �����Ѵ�.

        //Vector3 currentRot = transform.eulerAngles;

        ////if (currentRot.x > 60)
        ////{
        ////    currentRot.x = 60;
        ////}
        ////else if(currentRot.x < -60)
        ////{
        ////    currentRot.x = -60;
        ////}

        //currentRot.x = Mathf.Clamp(currentRot.x, -60.0f, 60.0f);

        //transform.eulerAngles = currentRot;
        #endregion

        // �Է� ���� ȸ�� ������ ������Ų��.
        if (rotateY)
        {
            rotX += x * rotSpeed * Time.deltaTime;
        }

        if (rotateX)
        {
            rotY += y * rotSpeed * Time.deltaTime;
        }

        // rotY�� ���� -60�� ~ 60�� ���̷� �����Ѵ�.
        rotY = Mathf.Clamp(rotY, -60.0f, 60.0f);

        // ȸ�� ����(���Ϸ� ��)�� �����.
        Vector3 dir = new Vector3(-rotY, rotX, 0);

        transform.localEulerAngles = dir;
    }
}
