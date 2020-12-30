using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShoot : MonoBehaviour
{
    public float ballSpeed;
    const int speedLimit = 55;
    public Rigidbody ball;
    public Vector3 initialPosBall;
    private bool charging;
    private bool shoot;

    void Start()
    {
        initialPosBall = ball.position;
        charging = false;
        shoot = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            charging = true;

            if (ballSpeed <= speedLimit)
                ballSpeed += 10 * Time.deltaTime;
        }
        else if(!Input.GetKey(KeyCode.Space) && charging)
        {
            charging = false;

            if (!charging)
            {
                shoot = true;
            }
        }
        if(shoot)
        {
            ball.transform.position += (Vector3.forward * ballSpeed) * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            ball.position = initialPosBall;
            ball.angularVelocity = Vector3.zero;
            ball.velocity = Vector3.zero;
            ballSpeed = 0;
            shoot = false;
            charging = false;
        }
    }
}
