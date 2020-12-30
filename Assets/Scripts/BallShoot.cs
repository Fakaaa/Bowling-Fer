using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShoot : MonoBehaviour
{
    public float ballSpeed;
    public Rigidbody ball;
    public GameObject triggerBall;
    public Vector3 initialPosBall;
    public bool shoot;
    public float force;
    public float forceLimit;
    private float timer =0;
    private float timeToReset = 15;

    void Start()
    {
        initialPosBall = ball.position;
        shoot = false;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            if(force <= forceLimit)
                force += ballSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (force >= 0)
                force -= ballSpeed * Time.deltaTime;
        }
        if(Input.GetKeyDown(KeyCode.Space) && !shoot && force > 0)
        {
            ball.AddForce(new Vector3(0, 0, force));
            shoot = true;
        }

        if(shoot)
            timer += Time.deltaTime;

        if(timer >= timeToReset )
        {
            resetBallValues();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(triggerBall == other.gameObject)
        {
            resetBallValues();
        }
    }

    void resetBallValues()
    {
        ball.position = initialPosBall;
        ball.angularVelocity = Vector3.zero;
        ball.velocity = Vector3.zero;
        force = 0;
        shoot = false;
        timer = 0;
    }
}
