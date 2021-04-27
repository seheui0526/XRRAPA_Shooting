using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // W, A, S, D 키를 눌러서 그 키에 맞춰서 상하 좌우로 이동하고 싶다.
    // 사용자의 입력을 받는다(키보드의 W, A, S, D 키).
    // 키 입력에 따라서 플레이어 오브젝트도 이동한다.
    // 속도(방향 -> 벡터, 크기 -> 속력 변수)

    public float moveSpeed = 0.2f;


    void Start()
    {
        
    }

    void Update()
    {
        transform.position = transform.position + Vector3.up * moveSpeed * Time.deltaTime;

        
    }
}
