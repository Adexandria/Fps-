using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Health : MonoBehaviour {
	public int life = 100;
	public int hit;
	public Animation anima;
	public Text healthtext;
	// Use this for initialization
	void Start () {
		
	}
  private  void OnTriggerEnter(Collider other)
	{
		if (other.tag == "enemy")
		{
			life -= hit;
		}
	}
	// Update is called once per frame
	void Update () {
		hit = Random.Range(1, 10);

		healthtext.text = "Health: " + life;
		if(life <= 0)
		{
			anima.Play();
		}
	}
}
