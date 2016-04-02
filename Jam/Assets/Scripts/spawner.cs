using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {

	public float timer;
	public float counter;
	public float minTime;
	public float maxTime;
	public float nextTime;
	public GameObject[] enemies;



	// Use this for initialization
	void Start () {
		timer = 0;
		nextTime = maxTime;
	
	}
	
	// Update is called once per frame
	void Update () {
	
		timer += Time.deltaTime;
		if(timer >= nextTime){
			timer = 0;
			spawn();

		}

	}


	void spawn(){

		var stop = GameObject.FindGameObjectWithTag("GameController").GetComponent<MissionBehaviour>().stopCounting;

		if(!stop){
			nextTime = Random.Range(minTime,maxTime);
			var x = Instantiate(enemies[Random.Range(0,enemies.Length -1)],transform.position,transform.rotation);
		}


	}

}
