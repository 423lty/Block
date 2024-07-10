using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallContllor : MonoBehaviour
{
    public float speed = 5f;
    //速さの最大値最小値
    public float minspeed = 5f;
    public float maxspeed = 10;
    Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        //RigidBodyにアクセスして変数に保管しておく
        body = GetComponent<Rigidbody>();   
        //斜め45度にすすぬ
        body.velocity = new Vector3(speed, speed, 0);

    }
    private void Update()
    {
        //現在の速度を取得
        Vector3 velocity = body.velocity;
        //速さの速度計算
        float calu = Mathf.Clamp(velocity.magnitude,minspeed, maxspeed);
        //速度を変更
        body.velocity = velocity.normalized * calu;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //playerの位置取得
            Vector3 playerPos = collision.transform.position;

            //ballの位置を取得
            Vector3 ballPos = collision.transform.position;

            //playerからみたボールの方向を計算
            Vector3 direPos = (ballPos - playerPos).normalized;

            float speed = body.velocity.magnitude;

            body.velocity += direPos * speed;
        }
    }


}
