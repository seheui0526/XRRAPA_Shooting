using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailMove : MonoBehaviour
{
    // Ÿ���� ���ؼ� ������ �ӵ��� �̵��ϰ� �ʹ�.
    // ����: Ÿ��, �ӷ�(ũ��)
    public GameObject target;
    public float moveSpeed = 5;

    void Start()
    {
        
    }

    void Update()
    {
        // 1. Ÿ�������� ������ �����Ѵ�(����ȭ).
        // target - me
        Vector3 dir = target.transform.position - transform.position;
        dir.Normalize();

        // 2. �� �������� �̵��Ѵ�.
        // p = p0 + vt
        transform.position += dir * moveSpeed * Time.deltaTime;
    }
}
