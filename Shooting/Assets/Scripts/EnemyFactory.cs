using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    // ���� ���� �ð����� Enemy�� �����ϰ� �ʹ�.
    // �ʿ� ��� : ���� �ð�(����), Enemy ������Ʈ, ��� �ð�
    

    public float delayTime = 2.0f;
    public GameObject enemy;

    float elapsedTime = 0;

    public int count = 3;

    public bool isChecked = true;
    //int checkCount = 1;

    void Start()
    {
        
    }

    void Update()
    {
        // ������ �ð��� �Ǿ����� �����Ѵ�.
        // 1. �� �����Ӹ��� ��� �ð��� �����Ѵ�.
        //if (checkCount > 0)
        //if (isChecked)
        //{
            elapsedTime += Time.deltaTime;

            // 2. ������ ��� �ð��� ���� �ð� �̻����� Ȯ���Ѵ�.
            if (elapsedTime >= delayTime)
            {
                //for (int i = 0; i < count; i++)
                //{
                //    GameObject go = Instantiate(enemy);
                //    go.transform.position = transform.position + new Vector3(Random.Range(-2.0f, 2.0f), 0, 0);
                //}

                // ����, �ð��� �Ǿ��ٸ� Enemy �������� �����Ѵ�.
                GameObject go = Instantiate(enemy);
                go.transform.position = transform.position;

                // ��� �ð��� 0�ʷ� �ʱ�ȭ�Ѵ�.
                elapsedTime = 0;
                isChecked = false;
                //checkCount = 0;
            }
        //}
    }
}
