using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ResultController : MonoBehaviour
{
    //テキスト生成
    public GameObject scoreText;
    public GameObject gameResultText;

    // Start is called before the first frame update
    void Start()
    {
        this.scoreText.GetComponent<TextMeshProUGUI>().text = "SCORE:" + SceneData.score;
        if(SceneData.totalBlocks == 0)
        {
            this.gameResultText.GetComponent<TextMeshProUGUI>().text = "GameClear";
        }
        else
        {
            this.gameResultText.GetComponent<TextMeshProUGUI>().text = "GameOver";
        }
    }

    public void OnReturnBottunPressed()
    {
        GameController.instance.ReturnStrt();
    }
}
