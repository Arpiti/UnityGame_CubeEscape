using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    private GameObject playerBall;
    // Use this for initialization
	void Start () {
        Debug.Log(" Game started ");
        playerBall = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 startP = new Vector3(-0.09f,1.01f,-42.5f);
        Vector3 endP = new Vector3(-0.09f,1.01f,-42.0f);
        playerBall.transform.position = Vector3.Lerp(startP, endP, 1f);
    }
}
