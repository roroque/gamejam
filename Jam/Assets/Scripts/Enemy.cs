using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float health;
	public bool dead;
	private Rigidbody2D body;
	public float speed;

	// Use this for initialization
	void Start () {
	
		body = gameObject.GetComponent<Rigidbody2D>();
		dead = false;
	}

	// Update is called once per frame
	void Update () {

		body.velocity = new Vector2(speed,0);
	
	}

	void OnTriggerEnter2D (Collider2D col){


		if(col.tag == "Player"){

			//colocar animacao

		}


	}

	public void TakeDamage(int damage){

		health = health - damage;

		if(health <= 0 && !dead){

			dead = true;
			Die();


		}


	}

	public void Die(){

		//realizar animacao de morte que seria destruir o colllider desse cara aqui
		Destroy(gameObject.GetComponent<Collider2D>());
	


	}





}
