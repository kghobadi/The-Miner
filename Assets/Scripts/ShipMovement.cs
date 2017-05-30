using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{

    Rigidbody ship;
 
    public float speed = 10f;



	void Start () {
        ship = GetComponent<Rigidbody>();
	   
	}


    void Update() {

        if (Input.GetKey(KeyCode.W))
        {
            ship.transform.Rotate(0, 0, 0); //add rotations so player can tell where they are going
            ship.AddRelativeForce(0, 0, speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            ship.AddRelativeForce(0, 0, -speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            ship.AddRelativeForce(-speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            ship.AddRelativeForce(speed, 0, 0);
        }

    }
}
