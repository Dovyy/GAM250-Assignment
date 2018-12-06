using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    private Transform lookAt;

	// Use this for initialization
	void Start () {
       lookAt = GameObject.FindGameObjectWithTag("Player").transform; // added tag to player so i can get his transform positions
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = lookAt.position; // setting cameras transform position to follow players transform position
	}
}
