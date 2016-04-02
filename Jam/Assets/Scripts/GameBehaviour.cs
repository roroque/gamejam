using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SocialPlatforms;
using System.Runtime.InteropServices;
using UnityEngine.SceneManagement;

public class GameBehaviour : MonoBehaviour {

	public float maxkills;
	public float maxdistance;

	// Use this for initialization
	void Start () {

		DontDestroyOnLoad (gameObject);
		DontDestroyOnLoad (this);

		load();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void GoToMothership(){
		
		SceneManager.LoadScene("Mothership");

	}


	public void GoToLeaderbords(){
		
		SceneManager.LoadScene("Score");

	}
	public void GoToCredits(){

		SceneManager.LoadScene("Credits");


	}
	public void GoToLevel(){

		SceneManager.LoadScene("Mission");


	}


	public void save(){

		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath + "/BadBarryData.dat");
		Data data = new Data();


		data.maxDistance = maxdistance;
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
			Data data = (Data)bf.Deserialize(file);
			file.Close();

			maxdistance = data.maxDistance;
			maxkills = data.maxkills;


		}

	}

}




[Serializable]
class Data
{

	public float maxDistance;
	public float maxkills;



}

