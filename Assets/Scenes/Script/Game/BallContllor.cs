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
        //RigidBody�ɃA�N�Z�X���ĕϐ��ɕۊǂ��Ă���
        body = GetComponent<Rigidbody>();   
        //�΂�45�x�ɂ�����
        body.velocity = new Vector3(speed, speed, 0);

    }
}
