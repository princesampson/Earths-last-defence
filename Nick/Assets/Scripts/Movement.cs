using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float moveSpeed = 5f;
    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical, 0f);
        transform.Translate(movement * Time.deltaTime * moveSpeed);

        Vector3 newPosition = transform.position + movement;

        newPosition.x = Mathf.Clamp(newPosition.x, -8, 8); //restricts player movement

        transform.position = newPosition;


    }
}
