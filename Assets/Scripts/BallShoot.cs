using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShoot : MonoBehaviour
{
    public float ballSpeed;
    const int speedLimit = 55;
    public Rigidbody ball;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if(ballSpeed <= speedLimit)
                ballSpeed += 10 * Time.deltaTime;
        }
        else
        {
            ball.transform.position += (Vector3.forward * ballSpeed) * Time.deltaTime;
        }
    }
}
