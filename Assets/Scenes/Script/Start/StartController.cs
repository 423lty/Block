using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartController : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        GameController.instance.StartGame();
    }
}
