using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkingTrap : MonoBehaviour {
    public float seconds = 10;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (seconds > 0 )
        {
            seconds -= Time.deltaTime;


        }

        if (seconds < 0)
        {
            Destroy(this.gameObject);
        }
        if (seconds == 0)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "Player" )
        {
            Debug.Log("Kolizja");
            if (col.gameObject.GetComponent<PlayerMovment>() != null)
            {
                Debug.Log("Wykonanie");
                col.gameObject.GetComponent<PlayerMovment>().SetAbletoMove(false);
                StartCoroutine(WaitCourtine(col));
            }

            else
            {
                Debug.Log("Else");
                col.gameObject.GetComponent<SecondPlayerMovment>().SetAbletoMove(false);
                StartCoroutine(SecondWaitCourtine(col));
            }
        }
    }

    private IEnumerator WaitCourtine(Collider2D col)
    {
        yield return new WaitForSeconds(3f);
        col.gameObject.GetComponent<PlayerMovment>().SetAbletoMove(true); //Plama Oleju
        yield return new WaitForSeconds(3f);
    }
    private IEnumerator SecondWaitCourtine(Collider2D col)
    {
        yield return new WaitForSeconds(3f);
        col.gameObject.GetComponent<SecondPlayerMovment>().SetAbletoMove(true);
        yield return new WaitForSeconds(3f);
    }
}
