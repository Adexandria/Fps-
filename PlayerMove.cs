using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
	public CharacterController controller;
	
	public Transform groundcheck;
	
	
	public GameObject weapon;
	
	

	public LayerMask groundMask;

	public float grounddistance =0.4f;
	public float speed = 10f;
	public float gravity =-9.81f;
	public float Jump =3f;

	
	
	public AudioSource running;
	public AudioSource Walking;
	
	Vector3 velocity;

	bool istrue;
	// Use this for initialization
	void Start () {
	speed = 5.0f;
		
	weapon.SetActive(true);


	}
	

	// Update is called once per frame
	void Update () {
		istrue = Physics.CheckSphere(groundcheck.position,grounddistance,groundMask);
		if(istrue && velocity.y < 0)
		{
           velocity.y =-2f;
		}
	 float x =Input.GetAxis("Horizontal");
	  float y=Input.GetAxis("Vertical");
	  Vector3 move = transform.right * x + transform.forward * y;
	  controller.Move(move * speed * Time.deltaTime);
	
		if(controller.velocity.x >= 0)
		{
			Walking.Play();
		}
	  if (Input.GetButtonDown("Jump")&& istrue)
	  {
        velocity.y =Mathf.Sqrt(Jump * -2f* gravity);
	  }
      velocity.y += gravity *Time.deltaTime;
	  controller.Move(velocity * Time.deltaTime);
		
		if (Input.GetKeyDown(KeyCode.LeftShift))
		{
			Walking.Stop();
			running.Play();
			speed += 10.0f;
			if(speed >= 30f)
			{
				speed = 5.0f;
			}

		}
		else {
			running.Stop();
		}
		
		if(controller.velocity.x <= 0)
		{
			Walking.Stop();
			running.Stop();
		}
		
	}

		
	

}
