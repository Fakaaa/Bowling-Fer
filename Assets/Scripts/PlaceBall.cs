using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceBall : MonoBehaviour
{
    public Rigidbody ball;
    public BallShoot script;
    private float speedMove;

    void Start()
    {
        speedMove = 10;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) && !script.shoot)
        {
            ball.transform.position += (Vector3.left * speedMove) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow) && !script.shoot)
        {
            ball.transform.position += (Vector3.right * speedMove) * Time.deltaTime;
        }
    }
}
