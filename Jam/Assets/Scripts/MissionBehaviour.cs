using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SocialPlatforms;
using System.Runtime.InteropServices;
using UnityEngine.SceneManagement;


public class MissionBehaviour : MonoBehaviour {

	public GameObject canvasDeath;
	public GameObject canvasPause;
	public float currentDistance;
	public float speed;
	public bool stopCounting;
	public float maxDistance;
	public float kills;
	public float maxkills;






	// Use this for initialization
	void Start () {
		currentDistance = 0;
		stopCounting = false;

		load();

	}
	
	// Update is called once per frame
	void Update () {
	
		if(!stopCounting){
			var x = Time.deltaTime * speed;

			currentDistance += x;



		}

	}

	public void GameOver(){

		if(currentDistance > maxDistance){

			maxDistance = currentDistance;

		}
		if(kills> maxkills){

			maxkills = kills;

		}

		stopCounting = true;

		canvasDeath.SetActive(true);

		save();

	}

	public void IncrementKills(){


		kills = kills + 1;

	}


	public void Pause(){
		if(!stopCounting){

			if(Time.timeScale > 0){
				canvasPause.SetActive(true);
				Time.timeScale = 0;
			}else{
				canvasPause.SetActive(false);
				Time.timeScale = 1;

			}


		}




	}



	public void save(){

		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath + "/BadBarryData.dat");
		Datas data = new Datas();


		data.maxDistance = maxDistance;
		data.maxkills = maxkills;
	


		bf.Serialize(file,data);
		file.Close();
		print("save");

	}

	public void load(){

		//		File.Delete (Application.persistentDataPath + "/Jam.dat");

		if(File.Exists(Application.persistentDataPath + "/Jam.dat")){
			print("load");
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/Jam.dat",FileMode.Open);
			Datas data = (Datas)bf.Deserialize(file);
			file.Close();

			maxDistance = data.maxDistance;
			maxkills = data.maxkills;


		}

	}

}




[Serializable]
class Datas
{

	public float maxDistance;
	public float maxkills;


	
}
