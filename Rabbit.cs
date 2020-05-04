using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour {
 public int speed;
 public Rigidbody rigidbody;
 public GameObject obj;
	// Use this for initialization
	void Start () {
		 rigidbody = GetComponent<Rigidbody>();
		speed =5;
		Move();
	}
	public void Move()
	{
    rigidbody.velocity = Vector3.right *speed * Time.deltaTime;
	}
	// Update is called once per frame
	void Update () {
		
	}
}