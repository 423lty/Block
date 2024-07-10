using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallContllor : MonoBehaviour
{
    public float speed = 5f;
    //�����̍ő�l�ŏ��l
    public float minspeed = 5f;
    public float maxspeed = 10;
    Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        //RigidBody�ɃA�N�Z�X���ĕϐ��ɕۊǂ��Ă���
        body = GetComponent<Rigidbody>();   
        //�΂�45�x�ɂ�����
        body.velocity = new Vector3(speed, speed, 0);

    }
    private void Update()
    {
        //���݂̑��x���擾
        Vector3 velocity = body.velocity;
        //�����̑��x�v�Z
        float calu = Mathf.Clamp(velocity.magnitude,minspeed, maxspeed);
        //���x��ύX
        body.velocity = velocity.normalized * calu;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //player�̈ʒu�擾
            Vector3 playerPos = collision.transform.position;

            //ball�̈ʒu���擾
            Vector3 ballPos = collision.transform.position;

            //player����݂��{�[���̕������v�Z
            Vector3 direPos = (ballPos - playerPos).normalized;

            float speed = body.velocity.magnitude;

            body.velocity += direPos * speed;
        }
    }


}
