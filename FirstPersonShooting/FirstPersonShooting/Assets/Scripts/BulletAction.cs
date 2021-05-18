using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAction : MonoBehaviour
{
    // 앞으로 총알이 나아간다.
    public float power = 10.0f;

    void Start()
    {
        
    }

    void Update()
    {
        //transform.position += new Vector3(0, 0, 1) * power * Time.deltaTime;
        //transform.position += transform.forward * power * Time.deltaTime;
        Vector3 dir = new Vector3(0, 0, 1);
        dir = transform.TransformDirection(dir);
        transform.position += dir * power * Time.deltaTime;
    }
}
