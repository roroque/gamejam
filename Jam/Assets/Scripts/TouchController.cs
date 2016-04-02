using UnityEngine;
using System.Collections;

public class TouchController : MonoBehaviour {

	PlayerMovement player;

	// Use this for initialization
	void Start () {

		player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetMouseButton(0)){

			var mousePos = Input.mousePosition;
			if(mousePos.x >= Screen.width/2){

				player.shoot();

			}else{

				player.jump();

			}
				
		}

		for (var i = 0; i < Input.touchCount; ++i) {

			Touch touch = Input.GetTouch(i);
			if (touch.phase == TouchPhase.Began) {

				if (touch.position.x >= (Screen.width/2)) {
				}else{


				}
			}
		}
	
	}
}
