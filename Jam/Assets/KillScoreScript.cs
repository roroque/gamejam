using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KillScoreScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var behave = GameObject.FindGameObjectWithTag("GameBehaviour").GetComponent<GameBehaviour>();
		if (Application.loadedLevelName == "Mission") {
			var mission = GameObject.FindGameObjectWithTag("GameController").GetComponent<MissionBehaviour>();
			gameObject.GetComponent<Text> ().text = mission.kills.ToString ();

		} else {
			gameObject.GetComponent<Text> ().text = behave.maxkills.ToString ();

		}
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
}
