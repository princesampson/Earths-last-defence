using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShooting : MonoBehaviour
{

    public GameObject laser;
    public Transform spawner;
    public AudioSource laserSound;

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AudioSource audioClip = Instantiate(laserSound, spawner.position, spawner.rotation);
            GameObject capsule = Instantiate(laser, spawner.position, spawner.rotation);
            Rigidbody laserRB = capsule.GetComponent<Rigidbody>();
            laserRB.velocity = transform.TransformDirection(Vector3.forward * 5);
            transform.parent = transform; // parents spawned object to it's spawned point in the hierarchy 
        }
       

	}
}
