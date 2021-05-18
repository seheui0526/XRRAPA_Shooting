using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // ���콺 �� Ŭ���� �ϸ� �Ѿ��� �߻�ǰ� �ϰ� �ʹ�.
    // �ʿ� ���: �Ѿ� ������Ʈ, ��Ŭ�� �Է�, �߻� ��ġ
    public GameObject bullet;
    public Transform firePosition;
    public GameObject fireEffect;

    ParticleSystem ps;

    void Start()
    {
       
    }

    void Update()
    {
        // ����, ���콺 �� Ŭ���� �ϸ�...
        //if (Input.GetMouseButtonDown(1))
        if (Input.GetButtonDown("Fire2"))
        {
            // �Ѿ��� firePosition ��ġ���� �����Ѵ�.
            GameObject go = Instantiate(bullet);
            go.transform.position = firePosition.position;
            go.transform.rotation = firePosition.rotation;
        }

        // ����, ���콺 �� Ŭ���� �ϸ�...
        if (Input.GetButtonDown("Fire1"))
        {
            // ���̸� �����ϰ� ī�޶��� ���� �������� �߻��ϰ� �ʹ�.
            
            // 1. ���̸� �����Ѵ�.
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

            // 2. ���̰� �ε��� ����� ������ ���� ������ �����Ѵ�.
            RaycastHit hitInfo;

            // 3. ���̸� �߻��Ѵ�!
            if (Physics.Raycast(ray, out hitInfo))
            {
                // �ε��� ����� �̸��� �ֿܼ� ����Ѵ�.
                print(hitInfo.transform.name);

                // �ε��� ����� ��ġ�� ����Ʈ�� �����ϰ� ����Ʈ�� �����Ѵ�.
                GameObject go = Instantiate(fireEffect);
                
                // ������ ����Ʈ�� ��ġ�� ���̰� ���� �������� �Ѵ�.
                go.transform.position = hitInfo.point;

                // ������ ����Ʈ�� up ������ ���̰� ���� ������ ��� ���Ϳ� ��ġ��Ų��.
                go.transform.up = hitInfo.normal;

                ps = go.GetComponent<ParticleSystem>();
                ps.Stop();
                ps.Play();
            }
        }
    }
}
