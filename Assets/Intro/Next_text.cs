using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next_text : MonoBehaviour {
	public GameObject txt,clse,instr;
	public int t;
	// Use this for initialization
	void Start () {
		t=PlayerPrefs.GetInt ("intro");
		if (t > 100)
			Application.LoadLevel ("Menu");
		if (t < 100)
			t = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown()
	{
		t++;
		if(t==1) txt.GetComponent<TextMesh>().text="I am the previous mayor\nof sity of cats\nCatVillage";
		if(t==2) txt.GetComponent<TextMesh>().text="And we need your help.\nI am retired now, so\nwe need new mayor";
		if (t == 3) {
			txt.GetComponent<TextMesh> ().text = "If you can`t or won`t\nhelp us, you can leave";
			clse.SetActive(true);
		}
		if (t == 4) {
			txt.GetComponent<TextMesh> ().text = "Thank you!\nDo you need instructions?";
			PlayerPrefs.SetInt ("intro", 101);
			GetComponent<TextMesh> ().text = "Game";
			clse.SetActive (false);
			instr.SetActive (true);
		}
		if (t == 5) {
			Application.LoadLevel ("Menu");
		}

		if (t > 100)
			Application.LoadLevel ("Menu");
	}
}
