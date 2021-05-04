using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // W, A, S, D Ű�� ������ �� Ű�� ���缭 ���� �¿�� �̵��ϰ� �ʹ�.
    // ������� �Է��� �޴´�(Ű������ W, A, S, D Ű).
    // Ű �Է¿� ���� �÷��̾� ������Ʈ�� �̵��Ѵ�.
    // �ӵ�(���� -> ����, ũ�� -> �ӷ� ����)


    // ���콺 ���� ��ư�� ������ �Ѿ��� �߻��ϰ� �ʹ�.
    // ����: �Ѿ� ������Ʈ, �ʱ� ��ġ ����


    public float moveSpeed = 0.2f;
    public GameObject bullet;
    public GameObject firePosition;

    void Start()
    {
        
    }

    void Update()
    {

        // 1. ���콺 ���� ��ư�� �Է��� �޴´�.
        if (Input.GetButtonDown("Fire1"))
        {
            // 2. �Ѿ��� �����Ѵ�.
            GameObject go = Instantiate(bullet);

            // 3. �Ѿ��� �ʱ� ��ġ�� firePosition�� ��ġ�� ��ġ��Ų��.
            go.transform.position = firePosition.transform.position;

            // 4. �Ѿ��� �߻� �Ҹ��� �÷����ϰ� �ʹ�.
            // �� ���� ������Ʈ�� ����� �ҽ� ������Ʈ�� �����´�.
            AudioSource bangSound = gameObject.GetComponent<AudioSource>();
            bangSound.Play();
            bangSound.volume = 0.5f;
        }
    }

    private void FixedUpdate()
    {
        //transform.position = transform.position + Vector3.right * moveSpeed * Time.deltaTime;

        // Input Manager�� �̸� �����Ǿ� �ִ� Axis�� �̸����� ���� �����´�.
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // ������ Axis ������ ���͸� �����.
        Vector3 dir = new Vector3(h, v, 0);

        // ������ ���̰� 1�� �ǵ��� ����ȭ�Ѵ�.
        dir.Normalize();

        // p = p0 + vt
        transform.position += dir * moveSpeed * Time.deltaTime;
    }

}
