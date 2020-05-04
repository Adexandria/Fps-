using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyhit : MonoBehaviour
{

	
	RaycastHit hit;
	public int Health =50;
	public GameObject enemy;
	private float distance = 5f;
	public LayerMask layer;
	public Animator anim;

	// Use this for initialization

	void Start()
	{
		Health = 50;
	}


	// Update is called once per frame
	void Update()
	{

		
		if (Physics.Raycast(enemy.transform.position, enemy.transform.forward, out hit, distance, layer))
		{
			if (hit.transform.tag == "Player")
			{
				anim.Play("Attack");

			}

		}
	}
}