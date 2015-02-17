﻿using UnityEngine;
using System.Collections;

public class DestructableObject : MonoBehaviour {
	public int lives = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision coll)
	{
		deathController (coll);
	}
	void deathController(Collision coll)
	{
		if (coll.gameObject.name == "Bullet(Clone)") 
		{
			lives--;
			if (lives <= 0) 
			{
				Destroy(this.gameObject);
			}
		}
	}
}
