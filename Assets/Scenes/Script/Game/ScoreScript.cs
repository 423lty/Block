using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //�N���X�̗B��̃C���X�^���X��ۏ؂���
    public static ScoreScript instance;

    //�X�R�A��\������text���ہ[�˂��
    public GameObject scoreText;
    private int totalScore;

    //Awake���\�b�h�ŃC���X�^���X�̏�����
    private void Awake()
    {
        //�C���X�^���X���̂��Ȃ�������ݒ�
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); //   �V�[�����܂����ł��C���X�^���X��񋟂ł���
        }
        else
        {
            Destroy(gameObject);
            Debug.LogError("�C���X�^���X��ێ����Ă��܂�");//���łɃC���X�^���X��ێ����Ă�����C���X�^���X��j��
        }

    }

    //�X�R�A���X�V����text���ہ[�˂�Ƃɔ��f
    public void ScoreManager(int score)
    {
        totalScore += score;
        UpdateScoreText();
    }
    private void UpdateScoreText()
    {
        this.scoreText.GetComponent<TextMeshProUGUI>().text = "score : " + totalScore.ToString();
    }

    public int GetCurrentScore()
    {
        return totalScore;
    }
}
