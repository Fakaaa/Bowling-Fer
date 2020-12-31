using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandle : MonoBehaviour
{
    public BallShoot bs;
    public KegelManager km;
    public Text shoots;
    public Text kegelsDown;
    public Text forceBall;
    public GameObject chuzaText;
    public GameObject allKegelsDown;
    public int maxAmountShoots;
    public bool canStillShoot;

    void Start()
    {
        chuzaText.SetActive(false);
        allKegelsDown.SetActive(false);
    }

    void Update()
    {
        shoots.text = "Shoots: " + bs.amountShoots.ToString();
        kegelsDown.text = "Kegels \n Down: " + km.kegelsDown.ToString();
        forceBall.text = "Force \n " + bs.force.ToString("F2");
        if (km.kegelsDown == 10 && bs.amountShoots < 1)
        {
            chuzaText.SetActive(true);
        }
        else if (km.kegelsDown == 10 && bs.amountShoots > 1)
        {
            allKegelsDown.SetActive(true);
        }
    }
}
