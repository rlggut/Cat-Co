using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prices : MonoBehaviour {
	public float cats,use_cat,get_cat;
	public float coins, use_coins,get_coins;
	public float food, use_food,get_food;
	public float get_lab;

	public bool farm, war, sciens,miner;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown()
	{
		if ((PlayerPrefs.GetFloat ("Cats") + cats > 0) &&
		   (PlayerPrefs.GetFloat ("Get_cat") + use_cat > 0) && (PlayerPrefs.GetFloat ("Coins") + coins > 0) &&
		   (PlayerPrefs.GetFloat ("Get_coins") + use_coins > 0) &&
		   (PlayerPrefs.GetFloat ("Food") + food > 0) && (PlayerPrefs.GetFloat ("Get_food") + use_food > 0)) {

			PlayerPrefs.SetFloat ("Cats", PlayerPrefs.GetFloat ("Cats") + cats);
			PlayerPrefs.SetFloat ("Get_cat",PlayerPrefs.GetFloat ("Get_cat") + get_cat);
			PlayerPrefs.SetFloat ("Use_cat",PlayerPrefs.GetFloat ("Use_cat") + use_cat);

			PlayerPrefs.SetFloat ("Coins", PlayerPrefs.GetFloat ("Coins") + coins);
			PlayerPrefs.SetFloat ("Get_coins",PlayerPrefs.GetFloat ("Get_coins") + get_coins);
			PlayerPrefs.SetFloat ("Use_coins",PlayerPrefs.GetFloat ("Use_coins") + use_coins);

			PlayerPrefs.SetFloat ("Food", PlayerPrefs.GetFloat ("Food") + food);
			PlayerPrefs.SetFloat ("Get_food",PlayerPrefs.GetFloat ("Get_food") + get_food);
			PlayerPrefs.SetFloat ("Use_food",PlayerPrefs.GetFloat ("Use_food") + use_food);

			PlayerPrefs.SetFloat ("Get_lab", PlayerPrefs.GetFloat ("Get_lab") + get_lab);

			if(war) PlayerPrefs.SetInt ("Warriors", PlayerPrefs.GetInt ("Warriors")+1);
			if(farm) PlayerPrefs.SetInt ("Farmers", PlayerPrefs.GetInt ("Farmers")+1);
			if(sciens) PlayerPrefs.SetInt ("Scientist", PlayerPrefs.GetInt ("Scientist")+1);
			if(miner) PlayerPrefs.SetInt ("Miners", PlayerPrefs.GetInt ("Miners")+1);
		}
			
	}
}
