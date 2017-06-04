using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZostawianiePułapki : MonoBehaviour {
    public GameObject trap;
    public int zapas = 3;
    public Transform createPosition;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.P))
        {

            if (zapas > 0)
            {
                GameObject go = Instantiate(trap);
                go.transform.position = createPosition.transform.position;
                zapas--;
            }
        }
	}
}
