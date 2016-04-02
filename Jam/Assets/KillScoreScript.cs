using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KillScoreScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

		var behave = GameObject.FindGameObjectWithTag("GameBehaviour").GetComponent<GameBehaviour>();

		gameObject.GetComponent<Text>().text = behave.maxkills.ToString();
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
}
