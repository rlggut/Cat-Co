using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Params : MonoBehaviour {
	public string name;
	public bool isfloat;
	private int x;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isfloat) {
			x = Mathf.CeilToInt((PlayerPrefs.GetFloat (name))*1000);
			GetComponent<TextMesh> ().text = (x/1000.0f).ToString();
		}
		else GetComponent<TextMesh> ().text = PlayerPrefs.GetInt (name).ToString ();
	}
}
