using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    //スコア
    public int score = 10;
    private blockGenerator blockGenerator;

    private void Start()
    {
        blockGenerator = FindObjectOfType<blockGenerator>();    
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (ScoreScript.instance != null)
        {
            ScoreScript.instance.ScoreManager(score);
        }
        else
        {
            Debug.LogError("ScoreScriptのインスタンスが存在しません");
        }
        //当たった時に呼び出す
        blockGenerator.BlockDestroyed();

        //オブジェクトの削除
        Destroy(gameObject);
    }
}
