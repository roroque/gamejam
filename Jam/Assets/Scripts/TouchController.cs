using UnityEngine;
using System.Collections;

public class TouchController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetMouseButton(0)){

			var mousePos = Input.mousePosition;
			if(mousePos.x >= Screen.width/2){
				print("right side of screen");

			}else{

				print("left side of screen");


			}
				
		}

		for (var i = 0; i < Input.touchCount; ++i) {

			Touch touch = Input.GetTouch(i);
			if (touch.phase == TouchPhase.Began) {

				if (touch.position.x >= (Screen.width/2)) {
					print("right side of screen");
				}else{

					print("left side of screen");

				}
			}
		}
	
	}
}
