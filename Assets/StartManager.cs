﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadLevelStart ()
    {
        Application.LoadLevel("Hes");
    }

    public void LeaveTheGame ()
    {
        Application.Quit();
    }
}
