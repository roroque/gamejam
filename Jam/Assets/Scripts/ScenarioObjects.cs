using UnityEngine;
using System.Collections;

public class ScenarioObjects : MonoBehaviour {

	public float speed;
	public Rigidbody2D body;

	// Use this for initialization
	void Start () {
	
		body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		body.velocity = new Vector2(speed * Time.deltaTime,0);
	
	}
}
