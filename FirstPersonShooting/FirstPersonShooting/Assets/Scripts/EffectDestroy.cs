using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectDestroy : MonoBehaviour
{
    // 2�� �ڿ� ���� �����ϰ� �ʹ�!
    public float elapsedTime = 2;

    float currentTime = 0;

    void Start()
    {
        
    }

    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime > elapsedTime)
        {
            Destroy(gameObject);
        }
    }
}
