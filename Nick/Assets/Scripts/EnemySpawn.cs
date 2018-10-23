using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] gameObjects;
    public Transform spawner;
    public Vector3 spawnValue;
    int randomInt;

	// Use this for initialization
	void Start ()
    {
        InvokeRepeating("Inst", 1f, 1f);
    }
	
	void Inst()
    {
        randomInt = Random.Range(0, gameObjects.Length);
        Vector3 spawnPosistion = new Vector3(Random.Range(-spawnValue.x, spawnValue.x),
            Random.Range(-spawnValue.y, spawnValue.y),
            Random.Range(-spawnValue.z, spawnValue.z));
        GameObject enemy = Instantiate(gameObjects[randomInt], spawnPosistion + spawner.position, spawner.rotation);
        Rigidbody enemyRB = enemy.GetComponent<Rigidbody>();
        enemyRB.velocity = transform.TransformDirection(Vector3.forward * 5);
        enemy.transform.parent = transform; 

    }
}
