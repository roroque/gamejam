﻿using UnityEngine;
using System.Collections;

public class MissionBehaviour : MonoBehaviour {

	public float missionDistance;
	public GameObject canvasDeath;
	public GameObject canvasWin;
	public float currentDistance;
	public float speed;
	public bool stopCounting;





	// Use this for initialization
	void Start () {
		currentDistance = 0;
		stopCounting = false;
	}
	
	// Update is called once per frame
	void Update () {
	
		if(!stopCounting){
			var x = Time.deltaTime * speed;


				
			currentDistance += x;





		}

	}

	public void GameOver(){
		stopCounting = true;

		canvasDeath.SetActive(true);

	}




}
