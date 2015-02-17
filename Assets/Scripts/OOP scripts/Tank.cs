using UnityEngine;
using System.Collections;

public class Tank : DestructableObject {
	public GameObject bulletPrefab;
	private GameObject turret;
	private GameObject nozzle;
	private float reloadTime;
	public float timeToReload;
	protected bool reloaded;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		reloadTimer ();
	}
	void findNozzleTurret()
	{

	}
	void aimTurret()
	{

	} 
	void reloadTimer()
	{
		reloadTime += Time.deltaTime;
		if (reloadTime >= timeToReload) 
		{
			reloaded = true;
		}
	}
	void resetReload()
	{
		reloadTime = 0f;
		reloaded = false;
	}

	protected void fireBullet()
	{
		Quaternion rotation = Quaternion.Euler(Vector3.up * turret.transform.rotation.eulerAngles.y);
			
		Instantiate(bulletPrefab, nozzle.transform.position, rotation);
		resetReload ();
	}
}
