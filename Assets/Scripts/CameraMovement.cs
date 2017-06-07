using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    Camera cammy;

    public Transform player;

    public int distance;

	void Start () {
        cammy = GetComponent<Camera>();
		
	}
	
	void Update () {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z - distance);
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            cammy.fieldOfView--;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            cammy.fieldOfView++;
        }
        //else
        //{
        //    cammy.fieldOfView++; THIS LOOKS LIKE A BLACK HOLE WHAT!!!
        //}
    }
}
