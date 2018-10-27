using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float m_Speed = 10f;
  




	// Use this for initialization
	void Start ()
    {
      
	}
	
	// Update is called once per frame
	void Update ()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * m_Speed;
        transform.Translate(x, 0, 0);

      
    }
}
Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
float angle = Mathf.Atan2(direction.z) * Mathf.Rad2Deg;
Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
transform.rotation = Quaternion.Slerp(transform.rotation, rotation, AimSpeed* Time.deltaTime);