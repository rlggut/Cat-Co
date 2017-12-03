using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_game : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown()
	{
		PlayerPrefs.SetInt ("Res", 11);
		PlayerPrefs.SetInt ("SeeRes", 0);

		PlayerPrefs.SetInt ("game_stage", 0);
		for (int i = 1; i < 100; i++) {
			PlayerPrefs.SetInt ("research" + i.ToString(), 0);
		}

		PlayerPrefs.SetInt ("Play", 1);
		PlayerPrefs.SetInt ("Farmers", 4);
		PlayerPrefs.SetInt ("Warriors",2);
		PlayerPrefs.SetInt ("Miners",1);
		PlayerPrefs.SetInt ("Scientist", 0);

		PlayerPrefs.SetFloat ("gold_pow", 1.0f);
		PlayerPrefs.SetFloat ("lab_pow", 1.0f);
		PlayerPrefs.SetFloat ("cat_pow", 1.0f);
		PlayerPrefs.SetFloat ("farm_pow", 1.0f);

		PlayerPrefs.SetFloat ("Cats",100.0f);
		PlayerPrefs.SetFloat ("Use_cat",0.0f);
		PlayerPrefs.SetFloat ("Get_cat",0.001f);


		PlayerPrefs.SetFloat ("Coins",10.0f);
		PlayerPrefs.SetFloat ("Use_coins",0.0f);
		PlayerPrefs.SetFloat ("Get_coins",0.1f);


		PlayerPrefs.SetFloat ("Food",10.0f);
		PlayerPrefs.SetFloat ("Use_food",-10.0f);
		PlayerPrefs.SetFloat ("Get_food",10.05f);

		PlayerPrefs.SetFloat ("Lab",0.0f);
		PlayerPrefs.SetFloat ("Get_lab",0.0f);


		Application.LoadLevel ("Game");
	}
}
