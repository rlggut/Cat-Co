using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Science_block : MonoBehaviour {
	public int st;
	public GameObject bl;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (st > PlayerPrefs.GetInt ("game_stage")) {
			bl.SetActive (true);
		}
		else
			bl.SetActive (false);
	}
}
