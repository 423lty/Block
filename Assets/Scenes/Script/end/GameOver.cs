using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    //wall bottonにぶつかったとき
    private void OnCollisionEnter(Collision collision)
    {
        //GameControllerスクリプトをインスタンス科
        if (GameController.instance == null)
        {
            GameController.instance = FindObjectOfType<GameController>();
        }
        if (GameController.instance != null)
        {
            GameController.instance.EndGame();

            Destroy(collision.gameObject);
        }
        else
        {
            Debug.LogError("インスタンスできていませんでした");
        }
    }
}
