using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitalMotion : MonoBehaviour {

    public Transform pointOfOrbit;
    public GameObject orbiter;

    public float rotationSpeed;
    public float orbitalSpeed;

    void Start () {
		
	}
	

	void Update () {
        orbiter.transform.RotateAround(orbiter.transform.position, Vector3.forward, rotationSpeed); //rotates object like a spinning planet. center is itself

        orbiter.transform.RotateAround(pointOfOrbit.transform.position, Vector3.forward, orbitalSpeed); //rotates object around another object. the orbital motion
		
	}
}
