using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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


    // Start is called before the first frame update
    void Start()
    {
        int px = -7, py = 5;
        int scoreDefalt = 0;
        //�u���b�N�̕\��
        for(int iy=0; iy<row; iy++)
        {
            for(int ix=0;ix<pol; ix++)
            {
                GameObject ob =Instantiate(blockPrefab);
                ob.transform.position = new Vector3(px + (ix * (span + blockScaleX)), py + (iy * (span + blockScaleY)),0);
            }
        }
        //�X�R�A������
        if(ScoreScript.instance!=null)
        {
            ScoreScript.instance.ScoreManager(scoreDefalt);
        }
        else
        {
            Debug.LogError("ScoreScript�̃C���X�^���X�����݂��܂���");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
