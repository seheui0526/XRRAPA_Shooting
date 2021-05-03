using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailMove : MonoBehaviour
{
    // 타겟을 향해서 일정한 속도로 이동하고 싶다.
    // 변수: 타겟, 속력(크기)
    public GameObject target;
    public float moveSpeed = 5;

    void Start()
    {
        
    }

    void Update()
    {
        // 1. 타겟으로의 방향을 설정한다(정규화).
        // target - me
        Vector3 dir = target.transform.position - transform.position;
        dir.Normalize();

        // 2. 그 방향으로 이동한다.
        // p = p0 + vt
        transform.position += dir * moveSpeed * Time.deltaTime;
    }
}
