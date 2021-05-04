using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    // ������ ���� ������ �ӵ��� �̵��Ѵ�.
    // �ʿ� ���: �ӵ�(����), �ӷ�
    // 1. ������ ���Ѵ�.
    // 2. �̵��Ѵ�.

    float moveSpeed = 8.0f;

    void Start()
    {
        
    }

    void Update()
    {
        // p = p0 + vt
        //transform.position += Vector3.up * moveSpeed * Time.deltaTime;

        Vector3 dir = new Vector3(0, 1, 0);
        transform.position += dir * moveSpeed * Time.deltaTime;
    }


    // �浹 �̺�Ʈ �Լ�(�ݹ� �Լ�)
    //private void OnCollisionEnter(Collision col)
    //{
    //    // ����, �ε��� ����� �̸��� "Enemy"��� �̸��� �����ϰ� �ִٸ�...
    //    if (col.gameObject.name.Contains("Enemy"))
    //    {
    //        Destroy(col.gameObject);

    //        // ���� �����Ѵ�.
    //        Destroy(gameObject);
    //    }
    //    else
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    private void OnTriggerEnter(Collider col)
    {
        // ����, �ε��� ����� �̸��� "Enemy"��� �̸��� �����ϰ� �ִٸ�...
        if (col.gameObject.name.Contains("Enemy"))
        {
            Destroy(col.gameObject);

            // ���� �����Ѵ�.
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
