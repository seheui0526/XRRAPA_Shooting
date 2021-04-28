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
}
