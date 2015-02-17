using UnityEngine;
using System.Collections;

public class Player : Tank {
	public float rotationSpeed = 8.5f;
	public float moveSpeed = 0.1f;
	Rigidbody rb;
	public Camera c;
	private Transform turret;
	private Transform nozzle;
	protected Vector3 targetPos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void determineWorldPos()
	{
		Vector3 mousePos = Input.mousePosition; //(x,y,z)
		mousePos.z = camera.transform.position.y - turret.transform.position.y;
		
		Vector3 worldPos = c.ScreenToWorldPoint(mousePos);
		
		targetPos = worldPos;
	}
	void undoVelocity()
	{
		if(rb.velocity != Vector3.zero)//(0,0,0)
		{
			rb.velocity = Vector3.zero;
		}
		if(rb.angularVelocity != Vector3.zero) 
		{
			rb.angularVelocity = Vector3.zero;
		}
	}
	void playerMovement()
	{
		if(Input.GetKey(KeyCode.W))
		{
			transform.Translate(Vector3.forward*moveSpeed);
		}
		
		if(Input.GetKey(KeyCode.S)) 
		{
			transform.Translate(-Vector3.forward*moveSpeed);
		}
		
		if(Input.GetKey(KeyCode.A)) 
		{
			transform.Rotate(-Vector3.up * rotationSpeed);
		}
		
		if(Input.GetKey(KeyCode.D)) 
		{
			transform.Rotate(Vector3.up * rotationSpeed);
		}
	}
}
