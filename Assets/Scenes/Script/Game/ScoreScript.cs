using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //クラスの唯一のインスタンスを保証する
    public static ScoreScript instance;

    //スコアを表示するtext今ぽーねんと
    private TextMeshProUGUI ScoreText;
    private int totalScore;

    //Awakeメソッドでインスタンスの初期化
    private void Awake()
    {
        //インスタンス自体がなかったら設定
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); //   シーンをまたいでもインスタンスを提供できる
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
           // Debug.LogError("インスタンスを保持しています");//すでにインスタンスを保持していたらインスタンスを破棄
        }

    }
    private void Start()
    {
        Initialize();
    }

    //スコアを更新してtext今ぽーねんとに反映
    public void ScoreManager(int score)
    {
        totalScore += score;
        UpdateScoreText();
    }
    private void UpdateScoreText()
    {
        if(ScoreText != null) { ScoreText.text = "score : " + totalScore.ToString(); }
    }

    public int GetCurrentScore()
    {
        return totalScore;
    }
    public void Initialize()
    {
        GameObject scoreTextObject = GameObject.FindWithTag("ScoreText");
        if(scoreTextObject != null)
        {
            ScoreText = scoreTextObject.GetComponent<TextMeshProUGUI>();
            UpdateScoreText();
        }
        else
        {
            Debug.LogError("");
        }
    }
    void OnSceneLoaded(Scene scene,LoadSceneMode mode)
    {
        //シーンがroadされたあとに再初期化
        StartCoroutine(InitializeAfterFrame());
    }

    private IEnumerator InitializeAfterFrame()
    {
        yield return null;
        Initialize();
    }
    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
