using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // W, A, S, D 키를 눌러서 그 키에 맞춰서 상하 좌우로 이동하고 싶다.
    // 사용자의 입력을 받는다(키보드의 W, A, S, D 키).
    // 키 입력에 따라서 플레이어 오브젝트도 이동한다.
    // 속도(방향 -> 벡터, 크기 -> 속력 변수)


    // 마우스 좌측 버튼을 누르면 총알을 발사하고 싶다.
    // 변수: 총알 오브젝트, 초기 위치 벡터


    public float moveSpeed = 0.2f;
    public GameObject bullet;
    public GameObject firePosition;

    void Start()
    {
        
    }

    void Update()
    {

        // 1. 마우스 좌측 버튼의 입력을 받는다.
        if (Input.GetButtonDown("Fire1"))
        {
            // 2. 총알을 생성한다.
            GameObject go = Instantiate(bullet);

            // 3. 총알의 초기 위치를 firePosition의 위치로 일치시킨다.
            go.transform.position = firePosition.transform.position;

            // 4. 총알의 발사 소리를 플레이하고 싶다.
            // 내 게임 오브젝트의 오디오 소스 컴포넌트를 가져온다.
            AudioSource bangSound = gameObject.GetComponent<AudioSource>();
            bangSound.Play();
            //bangSound.volume = 0.2f;
        }
    }

    private void FixedUpdate()
    {
        //transform.position = transform.position + Vector3.right * moveSpeed * Time.deltaTime;

        // Input Manager에 미리 설정되어 있는 Axis를 이름으로 값을 가져온다.
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 가져온 Axis 값으로 벡터를 만든다.
        Vector3 dir = new Vector3(h, v, 0);

        // 벡터의 길이가 1이 되도록 정규화한다.
        dir.Normalize();

        // p = p0 + vt
        transform.position += dir * moveSpeed * Time.deltaTime;
    }

}
