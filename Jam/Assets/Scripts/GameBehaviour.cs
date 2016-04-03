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

	private bool loadingSound = false; //assegura que tocará um audio por vez

	void Awake(){




	}


	// Use this for initialization
	void Start () {

		DontDestroyOnLoad (gameObject);
		DontDestroyOnLoad (this);


		load();

	}

	// Update is called once per frame
	void Update () {

	}


	public void GoToMothership(AudioSource audio){

		SceneManager.LoadScene("Mothership");


		if (!loadingSound) {
			loadingSound = true;
			StartCoroutine (PlayAudio (audio, "Mothership"));
		}

	}


	public void GoToLeaderbords(AudioSource audio){

		SceneManager.LoadScene("Score");

//		if (!loadingSound) {
//			loadingSound = true;
//			StartCoroutine (PlayAudio (audio, "Score"));
//		}

	}
	public void GoToCredits(AudioSource audio){

		SceneManager.LoadScene("Credits");


//		if (!loadingSound) {
//			loadingSound = true;
//			StartCoroutine (PlayAudio (audio, "Credits"));
//		}


	}


	public void GoToLevel(AudioSource audio){

		SceneManager.LoadScene("Mission");


//		if (!loadingSound) {
//			loadingSound = true;
//			StartCoroutine (PlayAudio (audio, "Mission"));
//		}

	}


	public void save(){

		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath + "/Jam.dat");
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

	//Inicia audio e troca de cena quando o audio acabar
	IEnumerator PlayAudio(AudioSource currentAudio,string levelName){
		currentAudio.PlayOneShot (currentAudio.clip);
		print ("comeca a tocar " + currentAudio.clip.length);
		yield return new WaitForSeconds (currentAudio.clip.length);
		//yield return new WaitForSeconds (1);
		loadingSound = false;

		SceneManager.LoadScene(levelName);


	}

}


[Serializable]
class Data
{
	public float maxDistance;
	public float maxkills;

}


