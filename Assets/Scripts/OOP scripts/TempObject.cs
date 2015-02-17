using UnityEngine;
using System.Collections;

public class TempObject : MonoBehaviour {
	public float maxLifeTime;
	private float lifeTime = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void removeAfterTime()
	{
		float delta = Time.deltaTime;
		lifeTime += delta;
		if (lifeTime > maxLifeTime) 
		{
			Destroy(this.gameObject);
		}
	}
}
