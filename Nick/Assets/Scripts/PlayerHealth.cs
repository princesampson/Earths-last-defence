using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

    [Range(0, 100)]
    public float currenthealth = 10;
    [Range(1, 100)]
    public float maxhealth = 100;
    float colisionDamage = 50f;
    float laserDamage = 15f;
    float debrisDamage = 10.5f;
    public bool alive = true;
    // Use this for initializatio0n

    public Image healthbar;
    void Start()
    {
        alive = true;
        currenthealth = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        float healthPercentage = currenthealth / maxhealth;
        healthbar.fillAmount = healthPercentage;

        if (currenthealth <= 0)
        {
            GameOver();
        }
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
        else if (other.gameObject.CompareTag("Asteroid"))
        {
            currenthealth -= debrisDamage;
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single); //Loads MainMenu Scene as a single scene
    }
}
