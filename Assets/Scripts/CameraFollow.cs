using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject toFollow;
    public Vector3 offset;
    public float limitCamera;

    void Update()
    {
        if((toFollow.transform.position.z + offset.z) < limitCamera)
            transform.position = toFollow.transform.position + offset;
    }
}
