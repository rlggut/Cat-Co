using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrows : MonoBehaviour {
	public int num,n;
	public GameObject[] res= new GameObject[100];
	public Transform p1, p2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		n = PlayerPrefs.GetInt ("SeeRes");
		p1 = res [PlayerPrefs.GetInt ("SeeRes")].transform;
		p2 = res [PlayerPrefs.GetInt ("SeeRes") + 1].transform;
	}
	void nul()
	{
		for (int i = 0; i <= PlayerPrefs.GetInt ("Res"); i++) {
			res [i].SetActive (false);
		}
	}
	void OnMouseDown()
	{
		if ((num + PlayerPrefs.GetInt ("SeeRes") >= 0) && (num + PlayerPrefs.GetInt ("SeeRes") < PlayerPrefs.GetInt ("Res"))) {
			p1 = res [PlayerPrefs.GetInt ("SeeRes")].transform;
			p2 = res [PlayerPrefs.GetInt ("SeeRes") + 1].transform;
			nul ();
			if (num == 1) {
				res [PlayerPrefs.GetInt ("SeeRes") + 2].transform.position = p2.position;
				res [PlayerPrefs.GetInt ("SeeRes") + 1].transform.position = p1.position;
				res [PlayerPrefs.GetInt ("SeeRes") + 1].SetActive (true);
				res [PlayerPrefs.GetInt ("SeeRes") + 2].SetActive (true);
			} else {				
				res [PlayerPrefs.GetInt ("SeeRes") - 1].transform.position = p1.position;
				res [PlayerPrefs.GetInt ("SeeRes")].transform.position = p2.position;
				res [PlayerPrefs.GetInt ("SeeRes") - 1].SetActive (true);
				res [PlayerPrefs.GetInt ("SeeRes")].SetActive (true);
			}
			PlayerPrefs.SetInt ("SeeRes",num + PlayerPrefs.GetInt ("SeeRes"));

		}
	}
}
