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
        print("��ư�� ���Ƚ��ϴ�~");
    }

    // ���� ���� �ٽ� �����Ѵ�.
    public void RestartScene()
    {
        SceneManager.LoadScene(0);
    }

    // ���� �����Ѵ�.
    public void QuitGame()
    {
        Application.Quit();
    }


    // ���� ���� �޴� UI�� Ȱ��ȭ�Ѵ�.
    public void ActivateMenuUI()
    {
        menuButtons.SetActive(true);
    }
}
