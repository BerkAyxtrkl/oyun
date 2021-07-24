using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
	
	[SerializeField]
	float Hassasiyet;
	
	public Transform body;
	
	float xRot = 0f;
	
	
	private void Update()
	{
		float rotX = Input.GetAxisRaw("Mouse X") * Hassasiyet * Time.deltaTime; 
		float rotY = Input.GetAxisRaw("Mouse Y") * Hassasiyet * Time.deltaTime * 0.9f; 
		
		xRot -= rotY;
		transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
		
		xRot = Mathf.Clamp(xRot, -75f, 75f );
		
		body.Rotate(Vector3.up * rotX);
		
		Cursor.visible = false;

		
	}
	
}