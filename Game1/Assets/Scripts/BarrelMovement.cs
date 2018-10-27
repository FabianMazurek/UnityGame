using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelMovement : MonoBehaviour
{
    public float AimSpeed = 1f;
    private Vector3 _mousePosition;
    public GameObject Barrel;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {




    }
    private void CannonMouseFollow()
    {
        // Translate the mouse position into a point in the world
        var position = Camera.main.ScreenToWorldPoint(_mousePosition);

        // Calculate the rotation to make the cannon look at the mouse position
        var rotation = Quaternion.LookRotation(position - Barrel.transform.position, Vector3.back);

        // Since we don't want to do a instant rotation, calculate the rotation towards the target rotation according to the turn state
        var targetRotation = Quaternion.RotateTowards(Barrel.transform.rotation, rotation, AimSpeed);

        // Assign the new rotation to the cannon
        Barrel.transform.rotation = new Quaternion(0, 0, targetRotation.z, targetRotation.w);
    }

}
