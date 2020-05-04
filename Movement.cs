using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float speed = 10.0f;
    public Rigidbody2D rigidbody;
    
    private bool moveleft;
    public bool move = true;
    // Use this for initialization
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        speed = 70.0f;
        Moveright();
        move = true;
    }

    // Update is called once per frame
    void Update()
    {
        speed += 0.05f;
        move = true;

        //  Handle();
    }

    private void Handle()
    {
        if (move)
        {
            StopMove();
        }
        else
        {
            if (moveleft)
            {
                LeftMove();
            }
            else if (!moveleft)
            {
                Moveright();
            }
        }
    }

    public void Moveup()
    {
        speed -= 0.5f;
        rigidbody.velocity= Vector3.up * speed * Time.deltaTime;
    }
    public void MoveDown()
    {
      speed -= 0.5f;
        rigidbody.velocity= Vector3.down * speed * Time.deltaTime;
    }
    public void Moveright()
    {
        rigidbody.velocity = Vector3.right * speed * Time.deltaTime;
    }
 public void  LeftMove()
    {
        rigidbody.velocity = Vector3.left * speed * Time.deltaTime;
    }
   
    private void StopMove()
    {
        move = false; ;
    }

   
}
