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
        // ���� �ִ� �÷��̾� ������Ʈ�� ã�´�.
        player = GameObject.Find("Player");

        // rate�� Ȯ���� �÷��̾� �������� �����Ѵ�.
        int draw = Random.Range(1, 101);
        //print(draw);

        if(draw <= rate)
        {
            dir = player.transform.position - transform.position;
            dir.Normalize();
        }
        // �������� Ȯ���� ������ �Ʒ��� �����Ѵ�.
        else
        {
            dir = Vector3.down;
        }
        
    }

    void Update()
    {
        // ���� �Ʒ��� �������� �ʹ�.
        //transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        //transform.position += new Vector3(0, -1, 0) * moveSpeed * Time.deltaTime;

        // �÷��̾ ���ؼ� ���� �ʹ�.
        transform.position += dir * moveSpeed * Time.deltaTime;
    }

    // ���� �ε��� ����� �����ϰ�, ���� �����Ѵ�.
    //private void OnCollisionEnter(Collision collision)
    //{
    //    // �ε��� ����� �̸��� "Player"��� �۾��� �����ϰ� �ִٸ�...
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
        // �ε��� ����� �̸��� "Player"��� �۾��� �����ϰ� �ִٸ�...
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
