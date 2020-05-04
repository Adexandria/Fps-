using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flicker : MonoBehaviour {
	public Light light;
	public int timeout = 2;
	private int timeon = 0;
	// Use this for initialization
	void Start () {
		StartCoroutine(flick());
	}
	IEnumerator flick()
	{ if(Time.time >= timeout)
		{
			light.enabled = !light.enabled;
		}else
		{
			light.enabled = light.enabled;
		}
	 yield return new WaitForSeconds(0.1f);
	}
	
	// Update is called once per frame
	void Update () {
		
		 
		
	}
}
