using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearTrap : MonoBehaviour {
    // Use this for initialization

    public bool otwarte;
    public Sprite zm;
    public Sprite ot;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && otwarte == true)
        {

             ot = this.gameObject.GetComponent<SpriteRenderer>().sprite;
            Debug.Log("Kolizja");
            if (col.gameObject.GetComponent<PlayerMovment>() != null)
            {
                Debug.Log("Wykonanie");
                col.gameObject.GetComponent<PlayerMovment>().speed = 0;
                StartCoroutine(WaitCourtine(col));
            }

            else
            {
                Debug.Log("Else");
                col.gameObject.GetComponent<SecondPlayerMovment>().speed = 0 ;
                StartCoroutine(SecondWaitCourtine(col));
                StartCoroutine(FixTrap());
                otwarte = false;
                
            }

            this.gameObject.GetComponent<SpriteRenderer>().sprite = zm;
        }
    }

    private IEnumerator WaitCourtine(Collider2D col)
    {
        yield return new WaitForSeconds(4f);
        col.gameObject.GetComponent<PlayerMovment>().speed = 2; //Plama Oleju
        yield return new WaitForSeconds(4f);
    }
    private IEnumerator SecondWaitCourtine(Collider2D col)
    {
        yield return new WaitForSeconds(4f);
        col.gameObject.GetComponent<SecondPlayerMovment>().speed = 2;
        yield return new WaitForSeconds(4f);
    }

    IEnumerator FixTrap ()
    {
        yield return new WaitForSeconds(10f);
        otwarte = true;
        this.gameObject.GetComponent<SpriteRenderer>().sprite = ot;
    }
}