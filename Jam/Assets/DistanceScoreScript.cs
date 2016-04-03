using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DistanceScoreScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

		var behave = GameObject.FindGameObjectWithTag("GameBehaviour").GetComponent<GameBehaviour>();
		if (Application.loadedLevelName == "Mission") {
			var mission = GameObject.FindGameObjectWithTag("GameController").GetComponent<MissionBehaviour>();
			gameObject.GetComponent<Text> ().text = mission.currentDistance.ToString ();

		} else {
			gameObject.GetComponent<Text> ().text = behave.maxdistance.ToString ();

		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
