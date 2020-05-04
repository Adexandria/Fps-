using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour {

	private int recharge;
	public Bulletshoot shoot;
	// Use this for initialization
	void Start () {
		recharge = 30;
	}
	private void OnTriggerEnter(Collider other)
	{
		if (shoot.Ammo < 130 && recharge >=0)
		{
			shoot.Ammo += recharge;
			recharge -= recharge;
			
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
