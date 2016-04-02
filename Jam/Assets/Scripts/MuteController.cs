using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//[RequireComponent(typeof (PlatformerCharacter2D))]

public class MuteController : MonoBehaviour
{

	private bool isMute = false; 
	public Sprite mute;
	public Sprite noMute;


	public void OnClick ()
	{
		isMute = !isMute;
		if (isMute) {
			print ("Mutou");

			AudioListener.volume = 0.0f;
			this.GetComponent<Image>().sprite = mute;
		}
		else{
			print ("naoMutou");

			AudioListener.volume = 1.0f;
			this.GetComponent<Image>().sprite = noMute;
		}
	}

//	public void Update()
//	{
//		if (AudioListener.volume == 0.0f) {
//			isMute = true;
//			this.GetComponent<Image> ().sprite = mute;
//		}
//		else{
//			isMute = false;
//
//			this.GetComponent<Image>().sprite = noMute;
//		}
//	}
}