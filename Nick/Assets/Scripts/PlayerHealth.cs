using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    [Range(0, 100)]
    public float currenthealth = 10;
    [Range(1, 100)]
    public float maxhealth = 100;
    float colisionDamage = 10.5f;
    float laserDamage = 15f;
    // Use this for initializatio0n

    public Image healthbar;
    void Start()
    {
        currenthealth = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        float healthPercentage = currenthealth / maxhealth;
        healthbar.fillAmount = healthPercentage;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            currenthealth -= colisionDamage;
        }
        else if (other.gameObject.CompareTag("Bullet"))
        {
            currenthealth -= laserDamage;
        }
    }
}
