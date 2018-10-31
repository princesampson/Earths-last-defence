using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ReturnToMenu : MonoBehaviour {

	public void MainMenu()
	{
		SceneManager.LoadScene("MainMenu", LoadSceneMode.Single); //Loads MainMenu Scene as a single scene
	}
}
