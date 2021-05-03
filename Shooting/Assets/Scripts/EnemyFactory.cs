using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    // 나는 일정 시간마다 Enemy를 생성하고 싶다.
    // 필요 요소 : 일정 시간(간격), Enemy 오브젝트, 경과 시간
    

    public float delayTime = 2.0f;
    public GameObject enemy;

    float elapsedTime = 0;

    public int count = 3;

    void Start()
    {
        
    }

    void Update()
    {
        // 일정한 시간이 되었는지 측정한다.
        // 1. 매 프레임마다 경과 시간을 누적한다.
        elapsedTime += Time.deltaTime;

        // 2. 누적된 경과 시간이 일정 시간 이상인지 확인한다.
        if (elapsedTime >= delayTime)
        {
            //for (int i = 0; i < count; i++)
            //{
            //    GameObject go = Instantiate(enemy);
            //    go.transform.position = transform.position + new Vector3(Random.Range(-2.0f, 2.0f), 0, 0);
            //}

            // 만일, 시간이 되었다면 Enemy 프리팹을 생성한다.
            GameObject go = Instantiate(enemy);
            go.transform.position = transform.position;

            // 경과 시간을 0초로 초기화한다.
            elapsedTime = 0;
        }
    }
}
