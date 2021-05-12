using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // singletone pattern
    public static UIManager instance;

    public GameObject menuButtons;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {

    }

    void Update()
    {

    }

    public void PrintTest()
    {
        print("버튼이 눌렸습니다~");
    }

    // 현재 씬을 다시 시작한다.
    public void RestartScene()
    {
        SceneManager.LoadScene(0);
    }

    // 앱을 종료한다.
    public void QuitGame()
    {
        Application.Quit();
    }


    // 게임 오버 메뉴 UI를 활성화한다.
    public void ActivateMenuUI()
    {
        menuButtons.SetActive(true);
    }
}
