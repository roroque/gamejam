using UnityEngine;
using System.Collections;

public class EndMission : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D (Collider2D col){


		if(col.tag == "Player"){
			var x = GameObject.FindGameObjectWithTag("GameController").GetComponent<MissionBehaviour>();
			x.GameOver();

		}


	}
}
