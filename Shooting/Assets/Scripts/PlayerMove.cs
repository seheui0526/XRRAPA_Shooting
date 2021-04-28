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
        //transform.position = transform.position + Vector3.right * moveSpeed * Time.deltaTime;

        // Input Manager�� �̸� �����Ǿ� �ִ� Axis�� �̸����� ���� �����´�.
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // ������ Axis ������ ���͸� �����.
        Vector3 dir = new Vector3(h, v, 0);

        // p = p0 + vt
        transform.position += dir * moveSpeed * Time.deltaTime;
        
    }

}
