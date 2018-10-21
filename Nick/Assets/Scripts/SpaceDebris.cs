using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceDebris : MonoBehaviour {

    public GameObject [] gameObjects ; 
    public Transform spawner;
    public Vector3 spawnValue; 

    int randomInt;

	// Use this for initialization
	void Start () {

        InvokeRepeating("Inst", 1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {

	}

    void Inst()
    {
        randomInt = Random.Range(0, gameObjects.Length);
        Vector3 spawnPostition = new Vector3(Random.Range(-spawnValue.x, spawnValue.x), 
            Random.Range(-spawnValue.y, spawnValue.y), 
            Random.Range(-spawnValue.z, spawnValue.z));
        GameObject asteroid = Instantiate(gameObjects[randomInt], spawnPostition + spawner.position, spawner.rotation);
        Rigidbody asteroidRB = asteroid.GetComponent<Rigidbody>();
        asteroidRB.velocity = transform.TransformDirection(Vector3.forward * 10);
        asteroid.transform.parent = transform;
    }
}
