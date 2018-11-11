using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	[Range(0, 100)]
	public float currenthealth = 0f;
	[Range(1, 100)]
	public float maxhealth = 100f;
    public float asteroidDamage = 50f;
    public float laserDamage = 15f;

	// Use this for initializatio0n

	public Image healthbar;
	void Start()
	{
        currenthealth = maxhealth;
        SetHealthBar();
	}

	// Update is called once per frame
	void Update()
	{

	}

    public void TakeDamage(float amount)
    {
        currenthealth -= amount;
    }
    public void SetHealthBar()
    {
        float healthPercentage = currenthealth / maxhealth;
       // healthbar.fillAmount = healthPercentage;
    }
}
