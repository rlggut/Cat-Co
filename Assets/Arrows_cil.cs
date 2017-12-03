using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrows_cil : MonoBehaviour {
	public Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position=offset+new Vector3(0,-3.0f*PlayerPrefs.GetInt ("SeeRes")/(PlayerPrefs.GetInt ("Res")-1),0);
	}
}
