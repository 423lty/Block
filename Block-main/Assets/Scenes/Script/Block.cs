using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    //�X�R�A
    public int score = 10;
    private void OnCollisionEnter(Collision collision)
    {
        if (ScoreScript.instance != true)
        {
            ScoreScript.instance.ScoreManager(score);
        }
        else
        {
            Debug.LogError("ScoreScript�̃C���X�^���X�����݂��܂���");
        }

        Destroy(gameObject);
    }
}
