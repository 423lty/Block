using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //�N���X�̗B��̃C���X�^���X��ۏ؂���
    public static ScoreScript instance;

    //�X�R�A��\������text���ہ[�˂��
    private TextMeshProUGUI ScoreText;
    private int totalScore;

    //Awake���\�b�h�ŃC���X�^���X�̏�����
    private void Awake()
    {
        //�C���X�^���X���̂��Ȃ�������ݒ�
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); //   �V�[�����܂����ł��C���X�^���X��񋟂ł���
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
           // Debug.LogError("�C���X�^���X��ێ����Ă��܂�");//���łɃC���X�^���X��ێ����Ă�����C���X�^���X��j��
        }

    }
    private void Start()
    {
        Initialize();
    }

    //�X�R�A���X�V����text���ہ[�˂�Ƃɔ��f
    public void ScoreManager(int score)
    {
        totalScore += score;
        UpdateScoreText();
    }
    private void UpdateScoreText()
    {
        if(ScoreText != null) { ScoreText.text = "score : " + totalScore.ToString(); }
    }

    public int GetCurrentScore()
    {
        return totalScore;
    }
    public void Initialize()
    {
        GameObject scoreTextObject = GameObject.FindWithTag("ScoreText");
        if(scoreTextObject != null)
        {
            ScoreText = scoreTextObject.GetComponent<TextMeshProUGUI>();
            UpdateScoreText();
        }
        else
        {
            Debug.LogError("");
        }
    }
    void OnSceneLoaded(Scene scene,LoadSceneMode mode)
    {
        //�V�[����road���ꂽ���Ƃɍď�����
        StartCoroutine(InitializeAfterFrame());
    }

    private IEnumerator InitializeAfterFrame()
    {
        yield return null;
        Initialize();
    }
    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
