using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShooting : MonoBehaviour {

    private RaycastHit hit;
    private Ray ray;
    public float rayDistance = 4f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * rayDistance, Color.green);

        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (hit.distance <= rayDistance)
                {
                    print("die");
                }
            }
           
        }

	}
}
