
using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour {


	private Rigidbody2D body;
	public GameObject shootingPoint;
	private float timerTillNext;

	[SerializeField] private float speed = 1;
	[SerializeField] private float m_JumpForce; //DEF = 400f
	[SerializeField] private float m_JumpForceX = 400f;
	//[SerializeField]private bool m_Jump = false;
	private float initPosition;
	private float positionGap = 1.0f;

	[SerializeField] private LayerMask m_WhatIsGround; // A mask determining what is ground to the character
	[SerializeField] private float k_GroundedRadius = .5f; // Radius of the overlap circle to determine if grounded Def = .2f
	private bool m_Grounded;            // Whether or not the player is grounded.
	private Transform m_GroundCheck;    // A position marking where to check if the player is grounded.

	//Armas
	[SerializeField] private int currentWeapon;
	public GameObject[] bullets;

	//Colisao caixas
	[SerializeField] private LayerMask m_WhatIsObject; // A mask determining what is ground to the character
	const float k_CollisionRadius = .0f; // Radius of the overlap circle to determine if grounded
	private bool m_Collision;            // Whether or not the player is grounded.
	private Transform m_CollisionCheck;    // A position marking where to check if the player is grounded.


	private void Awake()
	{
		// Setting up references.
		m_GroundCheck = transform.Find("GroundCheck");
		m_CollisionCheck = transform.Find ("CollisionCheck");
	}


	// Use this for initialization
	void Start () {

		body = gameObject.GetComponent<Rigidbody2D>();
		initPosition = gameObject.transform.position.x;

	}

	// Update is called once per frame
	void FixedUpdate () {
		timerTillNext -= Time.deltaTime;
		if (timerTillNext < 0) {
		
			timerTillNext = 0;
		}

		var x = false;

		Collider2D[] colliders = Physics2D.OverlapCircleAll(m_GroundCheck.position, k_GroundedRadius, m_WhatIsGround);
		for (int i = 0; i < colliders.Length; i++)
		{
			if (colliders[i].gameObject != gameObject)
				m_Grounded = true;
		}

		Collider2D[] collidersEnemy = Physics2D.OverlapCircleAll(m_CollisionCheck.position, k_CollisionRadius, m_WhatIsObject);
		for (int i = 0; i < collidersEnemy.Length; i++)
		{
			x = true;
			if (collidersEnemy [i].gameObject != gameObject) {
				m_Collision = true;

			}
		}
		if (!x) {
			
			m_Collision = false;
			
		}

		GetComponent<Animator> ().SetBool ("Colide", m_Collision);
		GetComponent<Animator> ().SetBool ("Ground", m_Grounded);

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
		timerTillNext -= timerTillNext;
		if(!(timerTillNext >0))
		print("sera");
		if (m_Grounded)
		{
			timerTillNext = 1;
			print("nao sei");
			// Add a vertical force to the player.
			m_Grounded = false;
			body.AddForce(new Vector2(m_JumpForceX, m_JumpForce));

			GetComponent<Animator>().SetTrigger("Jump");

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
