using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGravity : MonoBehaviour {

    Rigidbody celestialBody;

    public float gravitationalAcceleration;

    private float gravitationalConstant = 0.0000000000667f ;

    //Need a trigger Sphere collider to detect Grav Range


    void Start () {
        celestialBody = GetComponent<Rigidbody>();

        gravitationalAcceleration = (gravitationalConstant * celestialBody.mass) / Mathf.Pow((transform.lossyScale.magnitude / 2), 2); // g = G * M / r ^ 2 to calculate planets gravity


    }
	

	void Update () {
		
	}
}
