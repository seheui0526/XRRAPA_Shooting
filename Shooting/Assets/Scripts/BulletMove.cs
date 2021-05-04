using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    // 무조건 위로 일정한 속도로 이동한다.
    // 필요 요소: 속도(벡터), 속력
    // 1. 방향을 정한다.
    // 2. 이동한다.

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


    // 충돌 이벤트 함수(콜백 함수)
    //private void OnCollisionEnter(Collision col)
    //{
    //    // 만일, 부딪힌 대상의 이름이 "Enemy"라는 이름을 포함하고 있다면...
    //    if (col.gameObject.name.Contains("Enemy"))
    //    {
    //        Destroy(col.gameObject);

    //        // 나를 제거한다.
    //        Destroy(gameObject);
    //    }
    //    else
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    private void OnTriggerEnter(Collider col)
    {
        // 만일, 부딪힌 대상의 이름이 "Enemy"라는 이름을 포함하고 있다면...
        if (col.gameObject.name.Contains("Enemy"))
        {
            Destroy(col.gameObject);

            // 나를 제거한다.
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
