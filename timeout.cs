using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeout : MonoBehaviour {
  
	// Use this for initialization
	void Start () {
        StartCoroutine(loadSceneAfterDelay(7.0f));

    }

    IEnumerator loadSceneAfterDelay(float waitbySecs)
    {

        yield return new WaitForSeconds(waitbySecs);
        Application.LoadLevel(1);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
