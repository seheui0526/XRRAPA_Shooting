using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // W, A, S, D Ű�� ������ �� Ű�� ���缭 ���� �¿�� �̵��ϰ� �ʹ�.
    // ������� �Է��� �޴´�(Ű������ W, A, S, D Ű).
    // Ű �Է¿� ���� �÷��̾� ������Ʈ�� �̵��Ѵ�.
    // �ӵ�(���� -> ����, ũ�� -> �ӷ� ����)

    public float moveSpeed = 0.2f;


    void Start()
    {
        
    }

    void Update()
    {
        transform.position = transform.position + Vector3.up * moveSpeed * Time.deltaTime;

        
    }
}
