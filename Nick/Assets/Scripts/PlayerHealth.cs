using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	[Range(0, 100)]
	public float currenthealth = 10;
	[Range(1, 100)]
	public float maxhealth = 100;
	// Use this for initializatio0n

	public Image healthbar;
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		float healthPercentage = currenthealth / maxhealth;
		healthbar.fillAmount = healthPercentage;
	}
}
