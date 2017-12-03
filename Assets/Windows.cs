using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Windows : MonoBehaviour {

	private int t=0;
	public GameObject personal, science, market;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown()
	{
		t = (t + 1) % 3;
		if (t == 0) {
			personal.SetActive (true);
			science.SetActive (false);
			market.SetActive (false);
			GetComponent<TextMesh> ().text = "Science";
		}
		if (t == 1) {
			personal.SetActive (false);
			science.SetActive (true);
			market.SetActive (false);
			GetComponent<TextMesh> ().text = "Market";
		}
		if (t == 2) {
			personal.SetActive (false);
			science.SetActive (false);
			market.SetActive (true);
			GetComponent<TextMesh> ().text = "Personal";
		}
	}
}
