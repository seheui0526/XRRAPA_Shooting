using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // 마우스 우 클릭을 하면 총알이 발사되게 하고 싶다.
    // 필요 요소: 총알 오브젝트, 우클릭 입력, 발사 위치
    public GameObject bullet;
    public Transform firePosition;
    public GameObject fireEffect;

    ParticleSystem ps;

    void Start()
    {
       
    }

    void Update()
    {
        // 만일, 마우스 우 클릭을 하면...
        //if (Input.GetMouseButtonDown(1))
        if (Input.GetButtonDown("Fire2"))
        {
            // 총알을 firePosition 위치에서 생성한다.
            GameObject go = Instantiate(bullet);
            go.transform.position = firePosition.position;
            go.transform.rotation = firePosition.rotation;
        }

        // 만일, 마우스 좌 클릭을 하면...
        if (Input.GetButtonDown("Fire1"))
        {
            // 레이를 생성하고 카메라의 정면 방향으로 발사하고 싶다.
            
            // 1. 레이를 생성한다.
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

            // 2. 레이가 부딪힌 대상의 정보를 담을 변수를 선언한다.
            RaycastHit hitInfo;

            // 3. 레이를 발사한다!
            if (Physics.Raycast(ray, out hitInfo))
            {
                // 부딪힌 대상의 이름을 콘솔에 출력한다.
                print(hitInfo.transform.name);

                // 부딪힌 대상의 위치에 이펙트를 생성하고 이펙트를 실행한다.
                GameObject go = Instantiate(fireEffect);
                
                // 생성한 이펙트의 위치를 레이가 닿은 지점으로 한다.
                go.transform.position = hitInfo.point;

                // 생성한 이펙트의 up 방향을 레이가 닿은 지점의 노멀 벡터와 일치시킨다.
                go.transform.up = hitInfo.normal;

                ps = go.GetComponent<ParticleSystem>();
                ps.Stop();
                ps.Play();
            }
        }
    }
}
