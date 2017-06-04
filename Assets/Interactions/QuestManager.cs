using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour {
    public Text text;
    public GameObject player;
    public QuestPlace qp1;
    public QuestPlace qp2;
    public QuestPlace qp3;
    public QuestPlace qp4;
    public QuestPlace qp5;
    public QuestPlace qp6;
    public QuestPlace qp7;
    public QuestPlace qp8;
    public QuestPlace qp9;
    public QuestPlace qp10;
    public QuestPlace qp11;
    public Transform position1;
    public Transform position2;
    public Transform position3;
    public Transform position4;
    public Transform position5;
    public Transform position6;
    public Transform position7;
    public Transform position8;
    public Transform position9;
    public Transform position10;
    public Transform position11;


    // Use this for initialization
    void Start () {
        

        RandomizeQuests();

         
	}

   public void RandomizeQuests()
    {
        Debug.Log("Losowanie");
        int rnd = UnityEngine.Random.Range(0, 11);
        switch (rnd)
        {
            case 0:
                if (qp1.player == null)
                {
                    SendQuest("Wyrzuć śmieci! Natychmiast!", qp1);
                }

                else
                {
                    RandomizeQuests();
                }
                break;
            case 1:
               

                if (qp2.player == null)
                {
                    SendQuest("Zjedz kanapkę! Natychmiast!", qp2);
                }

                else
                {
                    RandomizeQuests();
                }
                break;
            case 2:
                
                if (qp3.player == null)
                {
                    SendQuest("Poświęć się w ofierze! Natychmiast!", qp3);
                }

                else
                {
                    RandomizeQuests();
                }
                break;
            case 3:
                
                if (qp4.player == null)
                {
                    SendQuest("Odpal atomice! Natychmiast!", qp4);
                }

                else
                {
                    RandomizeQuests();
                }
                break;
            case 4:
               
                if (qp5.player == null)
                {
                    SendQuest("Odbierz list! Natychmiast!", qp5);
                }

                else
                {
                    RandomizeQuests();
                }
                break;
            case 5:
               
                if (qp6.player == null)
                {
                    SendQuest("Wprowadź komunizm! Natychmiast!", qp6);
                }

                else
                {
                    RandomizeQuests();
                }
                break;
            case 6:
               
                if (qp7.player == null)
                {
                    SendQuest("Wyjmij Excalibur! Natychmiast!", qp7);
                }

                else
                {
                    RandomizeQuests();
                }
                break;
            case 7:
               
                if (qp8.player == null)
                {
                    SendQuest("Załóż działalność gospodarczą! Natychmiast!", qp8);
                }

                else
                {
                    RandomizeQuests();
                }
                break;
            case 8:
                
                if (qp9.player == null)
                {
                    SendQuest("Upoluj jednorożca! Natychmiast!", qp9);
                }

                else
                {
                    RandomizeQuests();
                }
                break;
            case 9:
                
                if (qp10.player == null)
                {
                    SendQuest("Znajdź X! Natychmiast!", qp10);
                }

                else
                {
                    RandomizeQuests();
                }
                break;
            case 10:
                
                if (qp11.player == null)
                {
                    SendQuest("Przestaw dźwignie! Natychmiast!", qp11);
                }

                else
                {
                    RandomizeQuests();
                }
                break;

        }
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void SendQuest (string message, QuestPlace qp)
    {
        Debug.Log("Send");
        text.text = message;
        if (qp != null)
        {
            qp.player = player;
            qp.qm = this;
        }
    }

    public void RandomizePositions ()
    {
        int rnd = UnityEngine.Random.Range(0, 12);

        switch (rnd)
        {
            case 0:
                qp1.gameObject.transform.position = position1.transform.position;
                qp2.gameObject.transform.position = position2.transform.position;
                qp3.gameObject.transform.position = position3.transform.position;
                qp4.gameObject.transform.position = position4.transform.position;
                qp5.gameObject.transform.position = position5.transform.position;
                qp6.gameObject.transform.position = position6.transform.position;
                qp7.gameObject.transform.position = position7.transform.position;
                qp8.gameObject.transform.position = position8.transform.position;
                qp9.gameObject.transform.position = position9.transform.position;
                qp10.gameObject.transform.position = position10.transform.position;
                qp11.gameObject.transform.position = position11.transform.position;
                break;
            case 1:
                qp1.gameObject.transform.position = position10.transform.position;
                qp2.gameObject.transform.position = position2.transform.position;
                qp3.gameObject.transform.position = position6.transform.position;
                qp4.gameObject.transform.position = position8.transform.position;
                qp5.gameObject.transform.position = position5.transform.position;
                qp6.gameObject.transform.position = position1.transform.position;
                qp7.gameObject.transform.position = position11.transform.position;
                qp8.gameObject.transform.position = position3.transform.position;
                qp9.gameObject.transform.position = position7.transform.position;
                qp10.gameObject.transform.position = position4.transform.position;
                qp11.gameObject.transform.position = position9.transform.position;
                break;
            case 2:
                qp1.gameObject.transform.position = position10.transform.position;
                qp2.gameObject.transform.position = position9.transform.position;
                qp3.gameObject.transform.position = position11.transform.position;
                qp4.gameObject.transform.position = position8.transform.position;
                qp5.gameObject.transform.position = position7.transform.position;
                qp6.gameObject.transform.position = position6.transform.position;
                qp7.gameObject.transform.position = position5.transform.position;
                qp8.gameObject.transform.position = position4.transform.position;
                qp9.gameObject.transform.position = position3.transform.position;
                qp10.gameObject.transform.position = position2.transform.position;
                qp11.gameObject.transform.position = position1.transform.position;
                break;
            case 3:
                qp1.gameObject.transform.position = position5.transform.position;
                qp2.gameObject.transform.position = position4.transform.position;
                qp3.gameObject.transform.position = position3.transform.position;
                qp4.gameObject.transform.position = position2.transform.position;
                qp5.gameObject.transform.position = position1.transform.position;
                qp6.gameObject.transform.position = position6.transform.position;
                qp7.gameObject.transform.position = position7.transform.position;
                qp8.gameObject.transform.position = position8.transform.position;
                qp9.gameObject.transform.position = position9.transform.position;
                qp10.gameObject.transform.position = position10.transform.position;
                qp11.gameObject.transform.position = position11.transform.position;
                break;
            case 4:
                qp1.gameObject.transform.position = position6.transform.position;
                qp2.gameObject.transform.position = position2.transform.position;
                qp3.gameObject.transform.position = position9.transform.position;
                qp4.gameObject.transform.position = position4.transform.position;
                qp5.gameObject.transform.position = position10.transform.position;
                qp6.gameObject.transform.position = position1.transform.position;
                qp7.gameObject.transform.position = position7.transform.position;
                qp8.gameObject.transform.position = position8.transform.position;
                qp9.gameObject.transform.position = position3.transform.position;
                qp10.gameObject.transform.position = position5.transform.position;
                qp11.gameObject.transform.position = position11.transform.position;
                break;
            case 5:
                qp1.gameObject.transform.position = position1.transform.position;
                qp2.gameObject.transform.position = position8.transform.position;
                qp3.gameObject.transform.position = position5.transform.position;
                qp4.gameObject.transform.position = position10.transform.position;
                qp5.gameObject.transform.position = position11.transform.position;
                qp6.gameObject.transform.position = position2.transform.position;
                qp7.gameObject.transform.position = position9.transform.position;
                qp8.gameObject.transform.position = position6.transform.position;
                qp9.gameObject.transform.position = position7.transform.position;
                qp10.gameObject.transform.position = position3.transform.position;
                qp11.gameObject.transform.position = position4.transform.position;

                break;
            case 6:
                qp1.gameObject.transform.position = position2.transform.position;
                qp2.gameObject.transform.position = position3.transform.position;
                qp3.gameObject.transform.position = position5.transform.position;
                qp4.gameObject.transform.position = position6.transform.position;
                qp5.gameObject.transform.position = position9.transform.position;
                qp6.gameObject.transform.position = position10.transform.position;
                qp7.gameObject.transform.position = position11.transform.position;
                qp8.gameObject.transform.position = position4.transform.position;
                qp9.gameObject.transform.position = position7.transform.position;
                qp10.gameObject.transform.position = position8.transform.position;
                qp11.gameObject.transform.position = position1.transform.position;



                break;
            case 7:
                qp1.gameObject.transform.position = position1.transform.position;
                qp2.gameObject.transform.position = position2.transform.position;
                qp4.gameObject.transform.position = position9.transform.position;
                qp5.gameObject.transform.position = position10.transform.position;
                qp6.gameObject.transform.position = position6.transform.position;
                qp7.gameObject.transform.position = position3.transform.position;
                qp8.gameObject.transform.position = position7.transform.position;
                qp9.gameObject.transform.position = position8.transform.position;
                qp10.gameObject.transform.position = position11.transform.position;
                qp11.gameObject.transform.position = position4.transform.position;
                qp3.gameObject.transform.position = position5.transform.position;



                break;
            case 8:
                qp1.gameObject.transform.position = position2.transform.position;
                qp2.gameObject.transform.position = position3.transform.position;
                qp3.gameObject.transform.position = position1.transform.position;
                qp4.gameObject.transform.position = position8.transform.position;
                qp5.gameObject.transform.position = position9.transform.position;
                qp6.gameObject.transform.position = position10.transform.position;
                qp7.gameObject.transform.position = position4.transform.position;
                qp8.gameObject.transform.position = position5.transform.position;
                qp9.gameObject.transform.position = position6.transform.position;
                qp10.gameObject.transform.position = position7.transform.position;
                qp11.gameObject.transform.position = position11.transform.position;
                break;
            case 9:
                qp8.gameObject.transform.position = position1.transform.position;
                qp1.gameObject.transform.position = position9.transform.position;
                qp10.gameObject.transform.position = position10.transform.position;
                qp5.gameObject.transform.position = position11.transform.position;
                qp4.gameObject.transform.position = position2.transform.position;
                qp3.gameObject.transform.position = position3.transform.position;
                qp7.gameObject.transform.position = position4.transform.position;
                qp5.gameObject.transform.position = position5.transform.position;
                qp2.gameObject.transform.position = position6.transform.position;
                qp7.gameObject.transform.position = position7.transform.position;
                qp6.gameObject.transform.position = position8.transform.position;
                break;
            case 10:
                qp1.gameObject.transform.position = position1.transform.position;
                qp2.gameObject.transform.position = position2.transform.position;
                qp3.gameObject.transform.position = position3.transform.position;
                qp4.gameObject.transform.position = position9.transform.position;
                qp5.gameObject.transform.position = position10.transform.position;
                qp6.gameObject.transform.position = position11.transform.position;
                qp7.gameObject.transform.position = position4.transform.position;
                qp8.gameObject.transform.position = position5.transform.position;
                qp9.gameObject.transform.position = position6.transform.position;
                qp10.gameObject.transform.position = position7.transform.position;
                qp11.gameObject.transform.position = position8.transform.position;
                break;

        }

    }
}
