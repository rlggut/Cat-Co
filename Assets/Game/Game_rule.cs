using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_rule : MonoBehaviour {

	private int t = 30;
	private float get_food, labs;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ((t == 0)&&(PlayerPrefs.GetInt ("Play")==1)) {
			t = 30;
			get_food=PlayerPrefs.GetInt ("Farmers")*3;
			PlayerPrefs.SetFloat ("Get_food",get_food);


			PlayerPrefs.SetFloat ("Cats", PlayerPrefs.GetFloat ("Cats") + PlayerPrefs.GetFloat ("Use_cat") +
				PlayerPrefs.GetFloat ("Get_cat")*PlayerPrefs.GetFloat("cat_pow"));

			PlayerPrefs.SetFloat ("Coins", PlayerPrefs.GetFloat ("Coins") + PlayerPrefs.GetFloat ("Use_coins") +
				PlayerPrefs.GetFloat ("Get_coins")*PlayerPrefs.GetFloat("gold_pow"));

			PlayerPrefs.SetFloat ("Food", PlayerPrefs.GetFloat ("Food") + PlayerPrefs.GetFloat ("Use_food") +
				PlayerPrefs.GetFloat ("Get_food")*PlayerPrefs.GetFloat("farm_pow"));

			PlayerPrefs.SetFloat ("Lab", PlayerPrefs.GetFloat ("Lab") + PlayerPrefs.GetFloat ("Get_lab")*PlayerPrefs.GetFloat("lab_pow"));
				
		}
		if(t>0) t--;
	}
}
