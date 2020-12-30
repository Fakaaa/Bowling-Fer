using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceBall : MonoBehaviour
{
    public Rigidbody ball;
    private float speedMove;

    void Start()
    {
        speedMove = 10;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            ball.transform.position += (Vector3.left * speedMove) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            ball.transform.position += (Vector3.right * speedMove) * Time.deltaTime;
        }
    }
}
