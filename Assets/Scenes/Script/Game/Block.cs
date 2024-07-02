using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    //�X�R�A
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
            Debug.LogError("ScoreScript�̃C���X�^���X�����݂��܂���");
        }
        //�����������ɌĂяo��
        blockGenerator.BlockDestroyed();

        //�I�u�W�F�N�g�̍폜
        Destroy(gameObject);
    }
}
