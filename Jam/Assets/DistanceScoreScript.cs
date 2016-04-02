using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DistanceScoreScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

		var behave = GameObject.FindGameObjectWithTag("GameBehaviour").GetComponent<GameBehaviour>();

		gameObject.GetComponent<Text>().text = behave.maxdistance.ToString();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
