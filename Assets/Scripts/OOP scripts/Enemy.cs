using UnityEngine;
using System.Collections;

public class Enemy : Tank {
	private float reloadTime;
	public float shootingRange;
	private Transform turret;
	private Transform nozzle;
	public Transform player;
	protected Vector3 targetPos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void determineTarget()
	{
		{
			Ray myRay = new Ray();
			myRay.origin = turret.position;
			myRay.direction = turret.forward;
			
			RaycastHit hitInfo;
			
			if (Physics.Raycast(myRay, out hitInfo, shootingRange)) 
			{
				string hitObjectName = hitInfo.collider.gameObject.name;
				if (hitObjectName == "Tank") 
				{
					fireBullet();
				}
			}
		}
	}
	void checkIfSeesEnemy()
	{
		if (player != null)
		{
			targetPos = player.position - Vector3.up * 0.11f; //(0,0.11,0)
			base.Update();
		}
	}
}
