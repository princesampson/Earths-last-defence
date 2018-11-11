using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidDamage : MonoBehaviour 
{
    public float damage = 50f;

     void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }


}
