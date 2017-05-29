using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitalMotion : MonoBehaviour {

    public Transform sun;
    public GameObject asteroid;

    public float rotationSpeed;
    public float orbitalSpeed;

    void Start () {
		
	}
	

	void Update () {
        asteroid.transform.RotateAround(asteroid.transform.position, Vector3.forward, rotationSpeed);
        asteroid.transform.RotateAround(sun.transform.position, Vector3.forward, rotationSpeed);
		
	}
}
