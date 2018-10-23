using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float moveSpeed = 1f;
    

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

        Vector3 newPositionSide = transform.position + movement; //sets new position for where restriction shall happen
        newPositionSide.x = Mathf.Clamp(newPositionSide.x, -8, 8); //restricts player movement to the side
        transform.position = newPositionSide;

        Vector3 newPositionUP = transform.position + movement;
        newPositionUP.y = Mathf.Clamp(newPositionUP.y, -8, 8);
        transform.position = newPositionUP;

    }
}
