using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestPlace : MonoBehaviour {
    public GameObject player;
    public QuestManager qm;
    public Timer timer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D (Collider2D col)
    {
        Debug.Log("COL");
        if (col.gameObject == player)
        {

            //if (player.GetComponent<PointsCounter>().points < 3)
            //{
                player.GetComponent<PointsCounter>().points++;
            player = null;
            qm.RandomizeQuests();
            qm.RandomizePositions();

            
                timer.ResetTimer();
              //  if (player.GetComponent<PointsCounter>().points == 3)
             //   {
               //     StartCoroutine(MyCourtine());
            //    }
          //  }

       //     else
       //     {
       //         Debug.Log("StefaN");
       //         qm.SendQuest("Wygrałeś!", null);
        //        StartCoroutine(MyCourtine());
        //
         // }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
   // IEnumerator MyCourtine()
   // {
   //     yield return new WaitForSeconds(3f);
   //     Application.LoadLevel("Start!");
  //  }

}
