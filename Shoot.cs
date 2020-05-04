using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public Transform firepoint;
    public GameObject fireball;
    public AudioSource audio1;
    // Update is called once per frame
    private void Start()
    {
        audio1 = GetComponent<AudioSource>();
    }
    void Update () {
        if (Input.GetButtonDown("Fire1"))
        {audio1.Play();
            Fire();
        }
	}
    void Fire()
    {
        
        Instantiate(fireball, firepoint.position, firepoint.rotation);
    }
}
