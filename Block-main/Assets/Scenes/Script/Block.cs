using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    //スコア
    public int score = 10;
    private void OnCollisionEnter(Collision collision)
    {
        if (ScoreScript.instance != true)
        {
            ScoreScript.instance.ScoreManager(score);
        }
        else
        {
            Debug.LogError("ScoreScriptのインスタンスが存在しません");
        }

        Destroy(gameObject);
    }
}
