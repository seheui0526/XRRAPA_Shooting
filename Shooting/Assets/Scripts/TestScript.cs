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

    // 콜리젼 3종 세트
    private void OnCollisionEnter(Collision collision)
    {
        print("충돌했쪄~");
    }

    private void OnCollisionStay(Collision collision)
    {
        print("절루가~");
    }

    private void OnCollisionExit(Collision collision)
    {
        print("끝!");
    }

    // 트리거 3종 세트
    private void OnTriggerEnter(Collider other)
    {
        print("아프냐");
    }

    private void OnTriggerStay(Collider other)
    {
        print("내 안에 너 있다~");
    }

    private void OnTriggerExit(Collider other)
    {
        print("나도 아프다~ ㅠㅠ");
    }
}
