﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Help : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown()
	{
		PlayerPrefs.SetInt ("intro", 0);
		Application.LoadLevel ("Intro");
	}
}
