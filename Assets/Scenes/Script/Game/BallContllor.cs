using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallContllor : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        //RigidBodyにアクセスして変数に保管しておく
        body = GetComponent<Rigidbody>();   
        //斜め45度にすすぬ
        body.velocity = new Vector3(speed, speed, 0);

    }
}
