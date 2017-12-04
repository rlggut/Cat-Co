using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Science : MonoBehaviour {


	public float cats,use_cat,get_cat;
	public float coins, use_coins,get_coins;
	public float food, use_food,get_food;
	public float lab, get_lab;
	public int war;

	public float kf_cat;
	public float kf_gold;
	public float kf_farm;
	public float kf_lab;
	public int stage;
	public GameObject check;
	public int num;
	public bool flag;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("research" + num.ToString()) == 1) {
			check.SetActive (true);
		}			
		flag = (PlayerPrefs.GetFloat ("Cats") + cats > 0) &&
			(PlayerPrefs.GetFloat ("Get_cat") + use_cat > 0) && (PlayerPrefs.GetFloat ("Coins") + coins > 0) &&
			(PlayerPrefs.GetFloat ("Get_coins") + use_coins > 0) &&
			(PlayerPrefs.GetFloat ("Food") + food > 0) && (PlayerPrefs.GetFloat ("Get_food") + use_food > 0)
			&& (PlayerPrefs.GetFloat ("Lab") + lab > 0)&& (PlayerPrefs.GetFloat ("Warriors") + war >= 0);
	}
	void OnMouseDown()
	{
		if ((PlayerPrefs.GetFloat ("Cats") + cats > 0) &&
			(PlayerPrefs.GetFloat ("Get_cat") + use_cat > 0) && (PlayerPrefs.GetFloat ("Coins") + coins > 0) &&
			(PlayerPrefs.GetFloat ("Get_coins") + use_coins > 0) &&
			(PlayerPrefs.GetFloat ("Food") + food > 0) && (PlayerPrefs.GetFloat ("Get_food") + use_food > 0)
			&& (PlayerPrefs.GetFloat ("Lab") + lab > 0)&& (PlayerPrefs.GetFloat ("Warriors") + war >= 0)) {

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
			PlayerPrefs.SetFloat ("Lab", PlayerPrefs.GetFloat ("Lab") + lab);

			PlayerPrefs.SetFloat ("gold_pow", PlayerPrefs.GetFloat("gold_pow")*kf_gold);
			PlayerPrefs.SetFloat ("lab_pow", PlayerPrefs.GetFloat ("lab_pow")*kf_lab);
			PlayerPrefs.SetFloat ("cat_pow", PlayerPrefs.GetFloat ("cat_pow")*kf_cat);
			PlayerPrefs.SetFloat ("farm_pow", PlayerPrefs.GetFloat ("farm_pow")*kf_farm);
			check.SetActive (true);
			PlayerPrefs.SetFloat ("Warriors",PlayerPrefs.GetFloat ("Warriors") + war);
			if(stage>PlayerPrefs.GetInt ("game_stage")) PlayerPrefs.SetInt ("game_stage", stage);
			PlayerPrefs.SetInt ("research" + num.ToString(), 1);
		}

	}
}