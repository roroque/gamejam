using UnityEngine;
using UnityEngine.SceneManagement;

using System.Collections;

public class InitMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("Trocando de cena");
		SceneManager.LoadScene("Mothership");

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
