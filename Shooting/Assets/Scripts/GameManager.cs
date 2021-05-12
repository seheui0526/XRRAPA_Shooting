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

    // 플레이어가 적을 격추할 때마다 1점씩 획득한다.


    void Start()
    {
        currentScore = 0;
        curScoreText.text = "현재 스코어: " + currentScore;

        // 만일, 최고 점수를 저장한 적이 있다면...
        if (PlayerPrefs.HasKey("myBestScore"))
        {
            // 그 키로 저장된 데이터를 가져온다.
            int bestPoint = PlayerPrefs.GetInt("myBestScore");
            bestScore = bestPoint;
        }
        else
        {
            bestScore = 0;
        }
        
        bestScoreText.text = "최고 스코어: " + bestScore;
    }

    void Update()
    {
        
    }

    // 점수 추가 함수
    public void AddScore(int point)
    {
        // 현재 점수를 가산한다.
        currentScore += point;
        curScoreText.text = "현재 스코어: " + currentScore;

        // 현재 점수가 최고 점수를 초과하였다면 현재 점수 값을 최고 점수 값으로 갱신한다.
        if(currentScore > bestScore)
        {
            bestScore = currentScore;
            bestScoreText.text = "최고 스코어: " + bestScore;
        }
    }

    // 최고 점수 저장 기능
    public string SaveScore()
    {
        PlayerPrefs.SetInt("myBestScore", bestScore);
        return "저장이 되었습니다!";
    }

    // 최고 점수 초기화하기
    void InitializeScore()
    {
        if (PlayerPrefs.HasKey("myBestScore"))
        {
            PlayerPrefs.SetInt("myBestScore", 0);
        }
    }
}
