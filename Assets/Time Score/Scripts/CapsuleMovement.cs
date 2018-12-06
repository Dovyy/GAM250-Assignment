using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour {

    private CharacterController controller;
    private Vector3 moveVector;

    private float speed = 5.0f;
    private float verticalVelocity = 0.0f;
    private float gravity = 12.0f;

    private bool isDead = false;

	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(1);
        }

        if (isDead)
            return;

        moveVector = Vector3.zero;

        if(controller.isGrounded)
        {
            verticalVelocity = -0.5f; // even if on the floor, still being pushed a bit to the floor
        }
        else
        {
            verticalVelocity -= gravity;
        }

        //x - LEFT and Right
        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
        //y - Up and Down
        moveVector.y = verticalVelocity;

        //z - Foward and BACKwardddd
        moveVector.z = speed;
        controller.Move(moveVector * Time.deltaTime); 
	}

    // it is being called when capsule hits something 
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
            if (hit.gameObject.tag == "Enemy")
            Death();

    }

    private void Death()
    {
        isDead = true;
        GetComponent<Score>().OnDeath();
        Debug.Log("dead");
    }
}
