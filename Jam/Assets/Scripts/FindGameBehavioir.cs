using UnityEngine;
using System.Collections;

public class FindGameBehavioir : MonoBehaviour {

	private GameBehaviour behave;



	public void GoToMothership(AudioSource audio){
		GameBehaviour behave = GameObject.FindGameObjectWithTag("GameBehaviour").GetComponent<GameBehaviour>();


		behave.GoToMothership(audio);

	}


	public void GoToLeaderbords(AudioSource audio){
		GameBehaviour behave = GameObject.FindGameObjectWithTag("GameBehaviour").GetComponent<GameBehaviour>();


		behave.GoToLeaderbords(audio);


	}

	public void GoToCredits(AudioSource audio){
		GameBehaviour behave = GameObject.FindGameObjectWithTag("GameBehaviour").GetComponent<GameBehaviour>();


		behave.GoToCredits (audio);


	}


	public void GoToLevel(AudioSource audio){
		GameBehaviour behave = GameObject.FindGameObjectWithTag("GameBehaviour").GetComponent<GameBehaviour>();

		behave.GoToLevel (audio);
	}


}
