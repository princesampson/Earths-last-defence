using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

    public GameObject enemylaser;
    private Ray ray;
    private RaycastHit hit;
    public float rayDistance = 15f;

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
            }
        }
    }
}
