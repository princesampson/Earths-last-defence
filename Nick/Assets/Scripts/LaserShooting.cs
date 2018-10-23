using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShooting : MonoBehaviour {

    private RaycastHit hit;
    private Ray ray;
    public float rayDistance = 10f;
    public GameObject laser;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ray = new Ray(transform.position, transform.forward);
            Debug.DrawRay(ray.origin, ray.direction * rayDistance, Color.green);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.distance <= rayDistance)
                {
                    print("die");
                }
            }
        }
       

	}
}
