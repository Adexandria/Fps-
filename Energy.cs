using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy : MonoBehaviour {
	int recharge;
	public Health life;
	// Use this for initialization
	void Start () {
		recharge = 10;
		
	}
	private void OnTriggerEnter(Collider other)
	{

		if(life.life < 100 && recharge >= 0 )
		{

         life.life += recharge;
			recharge -= recharge;
		
		}
		
	}
	// Update is called once per frame
	void Update () {
	
	}
}
