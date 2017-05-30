using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGravity : MonoBehaviour {

    Rigidbody celestialBody;

    public float gravRange;

    public float gravitationalAcceleration;

    private float gravitationalConstant = 0.0000000000667f ;


    void Start () {
        celestialBody = GetComponent<Rigidbody>();

        celestialBody.mass = celestialBody.mass * transform.localScale.magnitude; // Adjust rb mass to scale of object

        gravitationalAcceleration = (gravitationalConstant * celestialBody.mass) / Mathf.Pow((transform.localScale.magnitude / 2), 2); // g = G * M / r ^ 2 to calculate planets gravity


    }
	

	void Update () {
		
	}
}
