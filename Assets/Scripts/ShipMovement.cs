using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    Rigidbody ship;
 
    public float speed = 10f;

    private Vector3 targetPosition;
    private bool isMoving;
    

    //Freeze Camera rotations and find a way to get point n click movement working 

	void Start () {
        ship = GetComponent<Rigidbody>();

        targetPosition = transform.position;
        isMoving = false;
	   
	}


    void Update() {
        if (Input.GetMouseButton(0))
        {
            SetTargetPosition();
        }

        if (isMoving)
        {
            MovePlayer();
        }
        
    }

    void SetTargetPosition()
    {
        Plane plane = new Plane(Vector3.back, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float point = 0f;

        if(plane.Raycast (ray, out point))
        {
            targetPosition = ray.GetPoint(point);
        }

        isMoving = true;

    }

    void MovePlayer()
    {
        transform.LookAt(targetPosition);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if(transform.position == targetPosition)
        {
            isMoving = false;
        }

        Debug.DrawLine(transform.position, targetPosition, Color.red);

    }

}
