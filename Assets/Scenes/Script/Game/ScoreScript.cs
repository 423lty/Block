using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //クラスの唯一のインスタンスを保証する
    public static ScoreScript instance;

    //スコアを表示するtext今ぽーねんと
    public GameObject scoreText;
    private int totalScore;

    //Awakeメソッドでインスタンスの初期化
    private void Awake()
    {
        //インスタンス自体がなかったら設定
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); //   シーンをまたいでもインスタンスを提供できる
        }
        else
        {
            Destroy(gameObject);
            Debug.LogError("インスタンスを保持しています");//すでにインスタンスを保持していたらインスタンスを破棄
        }

    }

    //スコアを更新してtext今ぽーねんとに反映
    public void ScoreManager(int score)
    {
        totalScore += score;
        UpdateScoreText();
    }
    private void UpdateScoreText()
    {
        this.scoreText.GetComponent<TextMeshProUGUI>().text = "score : " + totalScore.ToString();
    }

    public int GetCurrentScore()
    {
        return totalScore;
    }
}
