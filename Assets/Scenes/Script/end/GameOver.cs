using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    //wall botton�ɂԂ������Ƃ�
    private void OnCollisionEnter(Collision collision)
    {
        //GameController�X�N���v�g���C���X�^���X��
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
            Debug.LogError("�C���X�^���X�ł��Ă��܂���ł���");
        }
    }
}
