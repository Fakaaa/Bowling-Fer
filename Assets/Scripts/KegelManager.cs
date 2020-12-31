using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KegelManager : MonoBehaviour
{
    const float maxRotation = 0.35f;
    public GameObject [] kegels;
    public bool [] kegelDown;
    public int kegelsDown;

    void Update()
    {
        for (int i = 0; i < kegels.Length ; i++)
        {
            if(kegels[i].transform.rotation.x >= maxRotation || kegels[i].transform.rotation.x <= -maxRotation ||
                kegels[i].transform.rotation.z >= maxRotation || kegels[i].transform.rotation.z <= -maxRotation)
            {
                if(!kegelDown[i])
                {
                    kegelsDown++;
                    kegelDown[i] = true;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < kegels.Length; i++)
        {
            if (kegels[i] == other.gameObject)
            {
                if (!kegelDown[i])
                {
                    kegelsDown++;
                    kegelDown[i] = true;
                }
            }
        }
    }
}
