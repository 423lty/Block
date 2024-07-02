using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClear : MonoBehaviour
{
    Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {
        //コンポーネントを保持する
        myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        //子供を生成したものがなくなったら
        if (myTransform.childCount == 0)
        {
            Time.timeScale = 0f;
        }
        
    }
}
