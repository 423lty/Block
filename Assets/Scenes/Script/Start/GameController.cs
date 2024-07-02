using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public static GameController instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //�J�n
    public void StartGame()
    {
        SceneData.score = 0;
        SceneManager.LoadScene("Game");
    }
    //�I��
    public void EndGame()
    {

        SceneData.score = ScoreScript.instance.GetCurrentScore();
        SceneManager.LoadScene("Result");
    }
    public void ReturnStrt()
    {
        SceneManager.LoadScene("Start");
    }
}
