using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidDamage : MonoBehaviour 
{
    public float damage = 50f;

     void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);

        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }


}
