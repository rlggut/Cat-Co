using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruciotns : MonoBehaviour {
	public GameObject txt,next;
	private int t=0;
	// Use this for initialization
	void Start () {
		transform.position = next.transform.position;
		next.SetActive (false);
		GetComponent<TextMesh> ().text = "Next";
	}
	
	// Update is called once per frame
	void Update () {
		if (t == 0)
			txt.GetComponent<TextMesh> ().text = "We have variety kind \nof resources:\nour people, gold, food and\nbuilding resources";
		if (t == 1)
			txt.GetComponent<TextMesh> ().text = "But more we have,\nthe price will rise.";
		if (t == 2)
			txt.GetComponent<TextMesh> ().text = "Our neighbors will\nfight for our treasure,\nif we have too much";
		if (t == 3)
			txt.GetComponent<TextMesh> ().text = "But we need gold for\nour science projects!\nAnd our people want\nto be wealthy!";
		if (t == 4)
			txt.GetComponent<TextMesh> ().text = "We can fight against\nneighbors and other troubles,\nbut we need our people";
		if (t == 5)
			txt.GetComponent<TextMesh> ().text = "If we won`t have enough\nworkplaces, we will have\ntroubles in our society";
		if (t == 6)
			txt.GetComponent<TextMesh> ().text = "Same thing with food";
		if (t == 7)
			txt.GetComponent<TextMesh> ().text = "But too much food is bad\nbecause of mices";
		if (t == 8)
			txt.GetComponent<TextMesh> ().text = "We will be safe from\nall of this troubles if we\ncreate supercomputers";
		if (t == 9) {
			txt.GetComponent<TextMesh> ().text = "It is a long road for\nour scientists, but\nit`s worth it!\nGood luck, mayor";
			GetComponent<TextMesh> ().text = "Game";
		}
		if (t > 10) {
			Application.LoadLevel ("Menu");
		}
	}
	void OnMouseDown()
	{
		t++;
	}
}
