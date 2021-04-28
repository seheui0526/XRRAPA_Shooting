using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tail : MonoBehaviour
{
    public GameObject target;
    public float speed = 0;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 dir = target.transform.position - transform.position;
        dir.Normalize();
        transform.position += dir * speed * Time.deltaTime;
    }
}
