
using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour {


	private Rigidbody2D body;
	public GameObject shootingPoint;

	[SerializeField] private float speed = 1;
	[SerializeField] private float m_JumpForce = 400f;
	//[SerializeField]private bool m_Jump = false;
	private float initPosition;
	private float positionGap = 1.0f;

	[SerializeField] private LayerMask m_WhatIsGround; // A mask determining what is ground to the character
	const float k_GroundedRadius = .2f; // Radius of the overlap circle to determine if grounded
	private bool m_Grounded;            // Whether or not the player is grounded.
	private Transform m_GroundCheck;    // A position marking where to check if the player is grounded.

	//Armas
	[SerializeField] private int currentWeapon;
	public GameObject[] bullets;

	private void Awake()
	{
		// Setting up references.
		m_GroundCheck = transform.Find("GroundCheck");

	}


	// Use this for initialization
	void Start () {

		body = gameObject.GetComponent<Rigidbody2D>();
		initPosition = gameObject.transform.position.x;

	}

	// Update is called once per frame
	void Update () {

		Collider2D[] colliders = Physics2D.OverlapCircleAll(m_GroundCheck.position, k_GroundedRadius, m_WhatIsGround);
		for (int i = 0; i < colliders.Length; i++)
		{
			if (colliders[i].gameObject != gameObject)
				m_Grounded = true;
		}

		Move();
	}
		

	private void Move(){

		if(playerIsMoving()){
			//Mover para esquerda ou direita
			if(gameObject.transform.position.x > initPosition)
				body.velocity = new Vector2(-speed,0);
			else
				body.velocity = new Vector2(speed,0);

		}else{

			body.velocity = new Vector2(0,0);


		}

	}

	private bool playerIsMoving(){
		if (Mathf.Abs (gameObject.transform.position.x - initPosition) < positionGap) {
			return false;
		}
		
		return true;

	}

	public void jump(){
		//ver animacao do personagem andando e pulando
		if (m_Grounded)
		{
			// Add a vertical force to the player.
			m_Grounded = false;
			body.AddForce(new Vector2(0f, m_JumpForce));
		}
	}

	public void shoot(){
		if (shootingPoint == null) {
			print ("Nao encontrado o shootingPoint");
			return;
		}

		Instantiate(bullets[currentWeapon],shootingPoint.transform.position,shootingPoint.transform.rotation);
	}

	public void changeWeapon(int numWeapon){
		currentWeapon = numWeapon;
	}
}
