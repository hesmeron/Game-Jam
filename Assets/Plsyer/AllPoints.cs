using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllPoints : MonoBehaviour {
    public PointsCounter pc1;
    public PointsCounter pc2;
    public Text text1;
    public Text text2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


	}

    public void EndOfTurn ()
    {
        Debug.Log("To jest już koniecf!");
        if (pc1.points > pc2.points)
        {
            text1.text = "Wygrałeś!";
            text2.text = "Przegrałeś";
            Destroy(pc1.gameObject);
            Destroy(pc2.gameObject);
            StartCoroutine(MyCourtine());
        }
        if (pc1.points < pc2.points)
        {
            text2.text = "Wygrałeś!";
            text1.text = "Przegrałeś";
            Destroy(pc1.gameObject);
            Destroy(pc2.gameObject);
            StartCoroutine(MyCourtine());
        }
        if (pc1.points == pc2.points)
        {
            text1.text = "Remis!";
            text2.text = "Remis!";
            Destroy(pc1.gameObject);
            Destroy(pc2.gameObject);
            StartCoroutine(MyCourtine());
        }
    }

    IEnumerator MyCourtine()
     {
         yield return new WaitForSeconds(3f);
        Application.LoadLevel("Start!");
     }
}
