using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGravity : MonoBehaviour {

    Rigidbody asteroidObject;

    private float incomingGravity;

	void Start () {

		asteroidObject = GetComponent<Rigidbody>();

        asteroidObject.mass = asteroidObject.mass * asteroidObject.transform.localScale.magnitude; // Adjust rb mass to scale of object

    }
	

	void Update () {
        incomingGravity = GetComponentInParent<PlanetGravity>().gravitationalAcceleration * asteroidObject.mass; // F = mg

        asteroidObject.AddRelativeForce(asteroidObject.transform.position.x, incomingGravity, 0); //Apply gravity to the object so that its pulled closer to the planet
		
	}
}
