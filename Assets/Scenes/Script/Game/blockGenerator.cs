using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class blockGenerator : MonoBehaviour
{
    //gameobject
    public GameObject blockPrefab;

    //�u���b�N�̍��W�傫��
    float span = 0.3f;      //���o
    int row = 4;            //�u���b�N�̗�
    int pol = 7;            //�u���b�N�̍s
    int blockScaleX = 2;    //�u���b�N�̕�
    int blockScaleY = 1;    //�u���b�N�̍���
    int totalBlocks;       //�u���b�N�̑���

    // Start is called before the first frame update
    void Start()
    {
        int px = -7, py = 5;            //
        int scoreDefalt = 0;            //�X�R�A�̃f�t�H���g
        totalBlocks = row * pol;
        //�u���b�N�̕\��
        for (int iy = 0; iy < row; iy++)
        {
            for (int ix = 0; ix < pol; ix++)
            {
                GameObject ob = Instantiate(blockPrefab);
                ob.transform.position = new Vector3(px + (ix * (span + blockScaleX)), py + (iy * (span + blockScaleY)), 0);
            }
        }
        //�X�R�A������
        if (ScoreScript.instance != null)
        {
            ScoreScript.instance.ScoreManager(scoreDefalt);
        }
        else
        {
            Debug.LogError("ScoreScript�̃C���X�^���X�����݂��܂���");
        }

    }

    //�u���b�N�����ׂĔj�󂳂ꂽ
    public void BlockDestroyed()
    {
        totalBlocks--;
        SceneData.totalBlocks = totalBlocks;    
        if(totalBlocks<=0) {

           // GameController.
            SceneManager.LoadScene("GameClear");
        }
    }
}
