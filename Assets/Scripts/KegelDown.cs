using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KegelDown : MonoBehaviour
{
    const float maxRotation = 0.35f;
    float timer = 0;
    float maxTimer = 1;

    void Update()
    {
        if (transform.rotation.x >= maxRotation || transform.rotation.x <= -maxRotation ||
            transform.rotation.z >= maxRotation || transform.rotation.z <= -maxRotation)
        {
            timer += Time.deltaTime;

            if (timer >= maxTimer)
                gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject == other.gameObject)
        {
            gameObject.SetActive(false);
        }
    }
}
