using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    

    public float scrollSpeed = 0.1f;

    Material matBG;

    void Start()
    {
        // 배경 오브젝트에서 MeshRenderer 컴포넌트를 가져온다.
        MeshRenderer mr = gameObject.GetComponent<MeshRenderer>();
        // MeshRenderer 컴포넌트에서 Material을 가져온다.
        //Material matBG = mr.material;
        matBG = mr.materials[0];
    }

    void Update()
    {
        // Material의 offset 값을 조정해야 한다.
        // offset의 y값을 매 프레임마다 일정 값(변수)만큼 증가시킨다.
        matBG.mainTextureOffset += new Vector2(0, 1) * scrollSpeed * Time.deltaTime;

    }
}
