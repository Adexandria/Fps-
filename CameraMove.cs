using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

	// Use this for initialization
public Transform Playerbody;
float xRotation =0f;
 
public float Sensitivity = 100f;
 

void Update()
{
float mouseX =Input.GetAxis("Mouse X") * Sensitivity ;
float mouseY =Input.GetAxis("Mouse Y") * Sensitivity  ;
xRotation -=mouseY;
xRotation = Mathf.Clamp(xRotation,-90f,90f);
transform.localRotation = Quaternion.Euler(xRotation,0f,0f);
Playerbody.Rotate(Vector3.up * mouseX);
}
}
