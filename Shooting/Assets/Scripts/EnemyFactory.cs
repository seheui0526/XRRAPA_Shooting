using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    // 나는 일정 시간마다 Enemy를 생성하고 싶다.
    // 필요 요소 : 일정 시간(간격), Enemy 오브젝트
    

    public float delayTime = 2.0f;
    public GameObject enemy;

    void Start()
    {
        
    }

    void Update()
    {
        // 일정한 시간이 되었는지 측정한다.

        // 만일, 시간이 되었다면 Enemy 프리팹을 생성한다.

    }
}
