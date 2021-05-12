using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float moveSpeed = 6;
    public GameObject player = null;
    public int rate = 60;
    public GameObject explosionFX;

    Vector3 dir;


    void Start()
    {
        // 씬에 있는 플레이어 오브젝트를 찾는다.
        player = GameObject.Find("Player");

        // rate의 확률로 플레이어 방향으로 설정한다.
        int draw = Random.Range(1, 101);
        //print(draw);

        if(draw <= rate)
        {
            // 만일, 플레이어를 찾은 상태라면...
            if (player != null)
            {
                dir = player.transform.position - transform.position;
                dir.Normalize();
            }
            // 그렇지 않다면(플레이어를 못 찾은 상태)...
            else
            {
                dir = Vector3.down;
            }
        }
        // 나머지의 확률로 방향을 아래로 설정한다.
        else
        {
            dir = Vector3.down;
        }
        
    }

    void Update()
    {
        // 나는 아래로 내려가고 싶다.
        //transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        //transform.position += new Vector3(0, -1, 0) * moveSpeed * Time.deltaTime;

        // 플레이어를 향해서 가고 싶다.
        transform.position += dir * moveSpeed * Time.deltaTime;
    }

    // 나와 부딪힌 대상을 제거하고, 나를 제거한다.
    //private void OnCollisionEnter(Collision collision)
    //{
    //    // 부딪힌 대상의 이름이 "Player"라는 글씨를 포함하고 있다면...
    //    //if (collision.gameObject.name == "Player")
    //    if (collision.gameObject.name.Contains("Player"))
    //    {
    //        Destroy(collision.gameObject);
    //        Destroy(gameObject);
    //    }
    //    else
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    private void OnTriggerEnter(Collider collision)
    {
        // 부딪힌 대상의 이름이 "Player"라는 글씨를 포함하고 있다면...
        //if (collision.gameObject.name == "Player")
        if (collision.gameObject.name.Contains("Player"))
        {
            // 이펙트 프리팹을 생성하고, 위치를 플레이어의 위치로 이동시킨다.
            GameObject go = Instantiate(explosionFX);
            go.transform.position = collision.transform.position;

            // 생성한 이펙트 오브젝트에서 파티클 시스템 컴포넌트를 가져온다.
            ParticleSystem ps = go.GetComponent<ParticleSystem>();
            ps.Play();

            Destroy(collision.gameObject);
            
            // 배경 음악을 교체하고, 메뉴 UI를 활성화한다.
            SoundManager.sm.PlayGameoverSound();
            UIManager.instance.ActivateMenuUI();

            // 최고 점수를 파일로 저장한다.
            string result = GameManager.instance.SaveScore();
            print(result);

            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    
}
