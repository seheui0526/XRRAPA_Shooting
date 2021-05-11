using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectModel : MonoBehaviour
{

    // 필요 요소 : 모델링 배열 변수
    //public GameObject model1;
    //public GameObject model2;
    //public GameObject model3;
    //public GameObject model4;

    public GameObject[] models = new GameObject[4];

    void Start()
    {
        // 4개의 모델링 중에서 1가지를 랜덤하게 선택한다.

        #region 배열을 모를 때
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

        //// 그 선택된 모델링 프리팹을 씬에 생성한다.
        //GameObject go = Instantiate(selection);
        #endregion
        
        // 배열을 알 때
        GameObject go = Instantiate(models[Random.Range(0, 4)]);

        // 생성된 프리팹 오브젝트를 나의 자식 오브젝트로 등록한다.
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
