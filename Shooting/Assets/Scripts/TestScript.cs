using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    // �ݸ��� 3�� ��Ʈ
    private void OnCollisionEnter(Collision collision)
    {
        print("�浹����~");
    }

    private void OnCollisionStay(Collision collision)
    {
        print("���簡~");
    }

    private void OnCollisionExit(Collision collision)
    {
        print("��!");
    }

    // Ʈ���� 3�� ��Ʈ
    private void OnTriggerEnter(Collider other)
    {
        print("������");
    }

    private void OnTriggerStay(Collider other)
    {
        print("�� �ȿ� �� �ִ�~");
    }

    private void OnTriggerExit(Collider other)
    {
        print("���� ������~ �Ф�");
    }
}
