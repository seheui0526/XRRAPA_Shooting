using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float moveSpeed = 6;
    public GameObject player;
    public int rate = 60;

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
            dir = player.transform.position - transform.position;
            dir.Normalize();
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
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    
}
