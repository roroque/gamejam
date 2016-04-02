using UnityEngine;
using System.Collections;

public class AutoScroll : MonoBehaviour {
	private RectTransform content;
	private float timer=0;
	private float speed=0.0001f;
	private bool enableScroll = true;
	private float distanceToScroll = 1f;
	public Canvas canvas;


	public float distanceScrollable;
	public RectTransform canvasRect;
	public float initialContentPosition;

	// Use this for initialization
	void Start () {
		content = (RectTransform)gameObject.transform;
		canvasRect = (RectTransform)canvas.transform;
		distanceScrollable = content.rect.height - canvasRect.rect.height;
		initialContentPosition = content.position.y;
	}
	
	// Update is called once per frame
	void Update () {

		if (enableScroll){
			if (timer < speed) {
				timer += Time.deltaTime;
			} else {
				timer = 0;
				print (content.position.y);
				if(content.position.y < 790.0005){
					content.position = new Vector3 (transform.position.x, transform.position.y + distanceToScroll, transform.position.z);
				}

			}
		}
	}

}
