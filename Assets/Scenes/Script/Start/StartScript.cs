using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    public float speed = 1.0f;
    public GameObject startTitle;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        this.startTitle.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //startTitle.color
    }
}
