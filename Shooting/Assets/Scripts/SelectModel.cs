using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectModel : MonoBehaviour
{

    // �ʿ� ��� : �𵨸� �迭 ����
    //public GameObject model1;
    //public GameObject model2;
    //public GameObject model3;
    //public GameObject model4;

    public GameObject[] models = new GameObject[4];

    void Start()
    {
        // 4���� �𵨸� �߿��� 1������ �����ϰ� �����Ѵ�.

        #region �迭�� �� ��
        //GameObject selection;

        //int draw = Random.Range(0, 4);

        //if(draw == 1)
        //{
        //    selection = model1;
        //}
        //else if(draw == 2)
        //{
        //    selection = model2;
        //}
        //else if(draw == 3)
        //{
        //    selection = model3;
        //}
        //else
        //{
        //    selection = model4;
        //}

        //// �� ���õ� �𵨸� �������� ���� �����Ѵ�.
        //GameObject go = Instantiate(selection);
        #endregion
        
        // �迭�� �� ��
        GameObject go = Instantiate(models[Random.Range(0, 4)]);

        // ������ ������ ������Ʈ�� ���� �ڽ� ������Ʈ�� ����Ѵ�.
        //go.transform.parent = transform;
        go.transform.SetParent(transform);
        go.transform.position = transform.position;
        go.transform.eulerAngles = new Vector3(0, 180.0f, 0);
        go.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);

    }

    void Update()
    {
        
    }
}
