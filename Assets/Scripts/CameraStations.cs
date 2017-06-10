using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStations : MonoBehaviour {

    Camera cammy;

    public Transform player;
    

	void Start () {
        cammy = GetComponent<Camera>();
		
	}
	
	void Update () {

        transform.LookAt(player);
    }
}
