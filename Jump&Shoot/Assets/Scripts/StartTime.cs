﻿using UnityEngine;
using System.Collections;

public class StartTime : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKey){
			Time.timeScale = 1;
		}
	}
}
