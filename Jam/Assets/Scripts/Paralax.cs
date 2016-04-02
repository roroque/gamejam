using UnityEngine;
using System.Collections;

public class Paralax : MonoBehaviour {

	public float speed = 0;
	public Paralax current;
	public Texture[] textures;

	float pos = 0;

	// Use this for initialization
	void Start () {
		current = this;



	}

	public void Go (){
		pos += speed;
		if (pos > 1.0f)
			pos -= 1.0f;

		var renderer = GetComponent<Renderer> ();
		renderer.material.mainTextureOffset = new Vector2 (pos, 0);


	}

	public void SelectTexture(int index){

		var myRenderer = gameObject.GetComponent<Renderer> ();
		myRenderer.material.mainTexture = textures[index];
	}


	// Update is called once per frame
	void Update () {
		Go();


	}


}
