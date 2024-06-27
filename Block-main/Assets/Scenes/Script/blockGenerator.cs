using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockGenerator : MonoBehaviour
{
    //gameobject
    public GameObject blockPrefab;

    //ブロックの座標大きさ
    float span = 0.3f;      //感覚
    int row = 4;            //ブロックの列
    int pol = 7;            //ブロックの行
    int blockScaleX = 2;    //ブロックの幅
    int blockScaleY = 1;    //ブロックの高さ


    // Start is called before the first frame update
    void Start()
    {
        int px = -7, py = 5;
        int scoreDefalt = 0;
        //ブロックの表示
        for(int iy=0; iy<row; iy++)
        {
            for(int ix=0;ix<pol; ix++)
            {
                GameObject ob =Instantiate(blockPrefab);
                ob.transform.position = new Vector3(px + (ix * (span + blockScaleX)), py + (iy * (span + blockScaleY)),0);
            }
        }
        //スコア初期化
        if(ScoreScript.instance!=null)
        {
            ScoreScript.instance.ScoreManager(scoreDefalt);
        }
        else
        {
            Debug.LogError("ScoreScriptのインスタンスが存在しません");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
