using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troubles : MonoBehaviour {
	public GameObject Display;
	public GameObject surp;
	public GameObject food;
	public GameObject food_txt;
	public GameObject neighbors;
	public GameObject neighbors_txt;
	public GameObject society;
	public GameObject well;
	public bool play=false;
	private int employ;
	private int regim=0;
	private float kf;
	// Use this for initialization
	void Start () {
		food.SetActive (false);
		neighbors.SetActive (false);
		society.SetActive (false);
		surp.SetActive (false);
		well.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		employ = PlayerPrefs.GetInt ("Farmers") + PlayerPrefs.GetInt ("Warriors") + PlayerPrefs.GetInt ("Miners") +
		PlayerPrefs.GetInt ("Scientist");

		if(PlayerPrefs.GetFloat("Food")>(employ*5+PlayerPrefs.GetFloat("Cats")*2))
		{
			Display.SetActive (false);
			play = true;
			food.SetActive (true);
			surp.SetActive (true);
			kf = PlayerPrefs.GetFloat ("Cats") * Random.Range(1,2.3f);
			PlayerPrefs.SetFloat("Food",PlayerPrefs.GetFloat ("Food")-kf);
			food_txt.GetComponent<TextMesh> ().text = (-kf).ToString ();
			surp.GetComponent<Animation> ().Play();
			PlayerPrefs.SetInt ("Play", 0);
		}

		if(PlayerPrefs.GetFloat("Coins")>(employ*3+PlayerPrefs.GetInt ("Miners")*2+PlayerPrefs.GetFloat("Cats")*1))
		{
			Display.SetActive (false);
			play = true;
			neighbors.SetActive (true);
			surp.SetActive (true);
			kf = employ*3+PlayerPrefs.GetFloat ("Cats") * Random.Range(0.7f,1.5f);
			PlayerPrefs.SetFloat("Coins",PlayerPrefs.GetFloat ("Coins")-kf);
			neighbors_txt.GetComponent<TextMesh> ().text = (-kf).ToString ();
			surp.GetComponent<Animation> ().Play();
			PlayerPrefs.SetInt ("Play", 0);
		}

		if (PlayerPrefs.GetInt ("game_stage") >= 8) {
			Display.SetActive (false);
			play = true;
			well.SetActive (true);
			surp.SetActive (true);
			surp.GetComponent<Animation> ().Play();
			PlayerPrefs.SetInt ("Play", 0);
		}

		if (!surp.GetComponent<Animation> ().isPlaying) {
			if(society.activeSelf) Application.LoadLevel("Over");
			if(well.activeSelf) Application.LoadLevel("Win");
			PlayerPrefs.SetInt ("Play", 1);
			Display.SetActive (true);
			play = false;
			food.SetActive (false);
			neighbors.SetActive (false);
			society.SetActive (false);
			surp.SetActive (false);
			well.SetActive (false);
		}

		if(((PlayerPrefs.GetFloat("Coins")<0)||(PlayerPrefs.GetFloat("Food")<0))&&(!surp.GetComponent<Animation> ().isPlaying))
		{
			Display.SetActive (false);
			play = true;
			society.SetActive (true);
			surp.SetActive (true);
			surp.GetComponent<Animation> ().Play();
			PlayerPrefs.SetInt ("Play", 0);
		}
	}
}
