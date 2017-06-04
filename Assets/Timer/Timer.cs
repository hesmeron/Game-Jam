using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public float seconds = 10;
    public Text clock;
    public bool start = false;
    public AllPoints ap;
    public ZostawianiePułapki zp;
    public CreateTrap ct;
	// Use this for initialization
	void Start () {
        clock.text = seconds.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		if (seconds > 0 && start == true)
        {
            seconds  -= Time.deltaTime; 
            clock.text =Mathf.Round(seconds).ToString();

        }
        if (seconds < 0)
        {
            seconds = 0;
            clock.text = seconds.ToString();
            ap.EndOfTurn();

        }

        if (seconds == 0)
        {
            ap.EndOfTurn();
        }
	}

    public void SetStart (bool stan)
    {
        start = stan;
    }

    public void ResetTimer ()
        {
        seconds = 10;
        if (zp.zapas < 3)
        {
            zp.zapas++;
        }

        if (ct.zapas < 3)
        {
            ct.zapas++;
        }
    }
}
