using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	[SerializeField] private float damage = 1;

	[SerializeField] private float speed = 1;

	private Rigidbody2D body;

	// Use this for initialization
	void Start () {
		body = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		body.velocity = new Vector2 (speed, 0);
	
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "Enemy") {
			col.gameObject.GetComponent<Enemy> ().TakeDamage (damage);
		}
	}


}
