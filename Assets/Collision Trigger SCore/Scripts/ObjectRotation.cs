using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{

	Rigidbody m_Rigidbody;
	float m_Speed;

	// Use this for initialization
	void Start ()
	{
		m_Rigidbody = GetComponent<Rigidbody> ();
		m_Speed = 2.0f;
        m_Rigidbody.velocity = transform.forward * m_Speed;
    }
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey ("left")) {
			transform.Rotate (0, 0, 1);
		}
		if (Input.GetKey ("right")) {
			transform.Rotate (0, -0, -1);
		}
	}
}

