using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceOfAvatar : MonoBehaviour {
    public int whichAvatar;
    public GameObject player;
    public Sprite avatar1;
    public Sprite avatar2;
    public Sprite avatar3;
    public Sprite avatar4;
    public Sprite avatar5;
    public Sprite avatar6;
    public Sprite avatar7;
    public Sprite avatar8;
    public Sprite avatar9;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetAvatarNumber (int wA)
    {
        whichAvatar = wA;

        switch (whichAvatar)
        {
            case 1:
                player.GetComponent<SpriteRenderer>().sprite = avatar1;
                player.GetComponent<Animator>().SetFloat("Coa", 1);
                break;
            case 2:
                player.GetComponent<SpriteRenderer>().sprite = avatar2;
                player.GetComponent<Animator>().SetFloat("Coa", 2);
                break;
            case 3:
                player.GetComponent<SpriteRenderer>().sprite = avatar3;
                player.GetComponent<Animator>().SetFloat("Coa", 3);
                break;
            case 4:
                player.GetComponent<SpriteRenderer>().sprite = avatar4;
                player.GetComponent<Animator>().SetFloat("Coa", 4);
                break;
            case 5:
                player.GetComponent<SpriteRenderer>().sprite = avatar5;
                player.GetComponent<Animator>().SetFloat("Coa", 5);
                break;
            case 6:
                player.GetComponent<SpriteRenderer>().sprite = avatar6;
                player.GetComponent<Animator>().SetFloat("Coa", 6);
                break;
            case 7:
                player.GetComponent<SpriteRenderer>().sprite = avatar7;
                player.GetComponent<Animator>().SetFloat("Coa", 7);
                break;
            case 8:
                player.GetComponent<SpriteRenderer>().sprite = avatar8;
                player.GetComponent<Animator>().SetFloat("Coa", 8);
                break;
            case 9:
                player.GetComponent<SpriteRenderer>().sprite = avatar9;
                player.GetComponent<Animator>().SetFloat("Coa", 9);
                break;

        }
        }

    
}
