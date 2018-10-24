using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

    public GameObject enemyLaser;
    private Ray ray;
    private RaycastHit hit;
    public float rayDistance = 5f;
    public Transform spawner;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * rayDistance, Color.red);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag("Player") && hit.distance <= rayDistance)
            {
                print("Player dead");
                GameObject capsule = Instantiate(enemyLaser, spawner.position, spawner.rotation);
                Rigidbody enemyLaserRB = capsule.GetComponent<Rigidbody>();
                enemyLaserRB.velocity = transform.TransformDirection(Vector3.forward * 1f);
                transform.parent = transform; // parents spawned object to it's spawned point in the hierarchy 
            }
        }
    }
}
