using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class MoveRandomly : MonoBehaviour {
	NavMeshAgent nav;
	public float Timer;
	bool Movement;
	// Use this for initialization
	void Start () {
		nav = GetComponent<NavMeshAgent>();
	}
	 Vector3 NewPosition()
	{
		float x = Random.Range(-50, 60);
		float z = Random.Range(-20, 60);
		Vector3 pos = new Vector3(x, 0, z);
		return pos;
	}
	IEnumerator Move()
	{
		Movement = true;
		yield return new WaitForSeconds(Timer);
		NewPath();
		Movement = false;
	}
	void NewPath()
	{
		nav.SetDestination(NewPosition());
	}
	// Update is called once per frame
	void Update () {
		if (!Movement)
		{
			StartCoroutine(Move());
		}
	}
}
