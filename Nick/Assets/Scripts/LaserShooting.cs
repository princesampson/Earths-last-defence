using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShooting : MonoBehaviour {

    private RaycastHit hit;
    private Ray ray;
    public float rayDistance = 15f;
    public GameObject laser;
    public Transform spawner;

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject capsule = Instantiate(laser, spawner.position, spawner.rotation);
            Rigidbody laserRB = capsule.GetComponent<Rigidbody>();
            laserRB.velocity = transform.TransformDirection(Vector3.forward * 5);
            transform.parent = transform; // parents spawned object to it's spawned point in the hierarchy 

            /* ray = new Ray(transform.position,transform.forward);
             Debug.DrawRay(ray.origin, ray.direction * rayDistance, Color.green);

             if (Physics.Raycast(ray, out hit))
             {
                 if (hit.distance <= rayDistance)
                 {
                     print("die");
                     GameObject capsule = Instantiate(laser, spawner.position, spawner.rotation);
                     Rigidbody laserRB = capsule.GetComponent<Rigidbody>();
                     laserRB.velocity = transform.TransformDirection(Vector3.forward * 5);
                     transform.parent = transform; // parents spawned object to it's spawned point in the hierarchy 
                 }
             }*/
        }
       

	}
}
