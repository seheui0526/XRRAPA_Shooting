using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text curScoreText;
    public Text bestScoreText;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    int currentScore = 0;
    public int bestScore = 0;

    // �÷��̾ ���� ������ ������ 1���� ȹ���Ѵ�.


    void Start()
    {
        currentScore = 0;
        curScoreText.text = "���� ���ھ�: " + currentScore;

        // ����, �ְ� ������ ������ ���� �ִٸ�...
        if (PlayerPrefs.HasKey("myBestScore"))
        {
            // �� Ű�� ����� �����͸� �����´�.
            int bestPoint = PlayerPrefs.GetInt("myBestScore");
            bestScore = bestPoint;
        }
        else
        {
            bestScore = 0;
        }
        
        bestScoreText.text = "�ְ� ���ھ�: " + bestScore;
    }

    void Update()
    {
        
    }

    // ���� �߰� �Լ�
    public void AddScore(int point)
    {
        // ���� ������ �����Ѵ�.
        currentScore += point;
        curScoreText.text = "���� ���ھ�: " + currentScore;

        // ���� ������ �ְ� ������ �ʰ��Ͽ��ٸ� ���� ���� ���� �ְ� ���� ������ �����Ѵ�.
        if(currentScore > bestScore)
        {
            bestScore = currentScore;
            bestScoreText.text = "�ְ� ���ھ�: " + bestScore;
        }
    }

    // �ְ� ���� ���� ���
    public string SaveScore()
    {
        PlayerPrefs.SetInt("myBestScore", bestScore);
        return "������ �Ǿ����ϴ�!";
    }

    // �ְ� ���� �ʱ�ȭ�ϱ�
    void InitializeScore()
    {
        if (PlayerPrefs.HasKey("myBestScore"))
        {
            PlayerPrefs.SetInt("myBestScore", 0);
        }
    }
}
