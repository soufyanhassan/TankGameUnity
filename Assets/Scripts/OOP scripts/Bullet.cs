using UnityEngine;
using System.Collections;

public class Bullet : TempObject {
	public float speed;
	private float lifeTime = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		moveBullet ();
	}

	void moveBullet()
	{
		float delta = Time.deltaTime;
		transform.Translate(Vector3.forward * speed * delta);
	}
	void removeOnImpact()
	{
		
	}
}
