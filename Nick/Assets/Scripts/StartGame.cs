using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartGame : MonoBehaviour {

	public void PlayGame()
	{
		SceneManager.LoadScene("SampleScene", LoadSceneMode.Single); //Starts the game scene as a single scene
	}
}
