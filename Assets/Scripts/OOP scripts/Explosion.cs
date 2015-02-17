using UnityEngine;
using System.Collections;

public class Explosion : TempObject {
	public GameObject explosionPrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void fadeExplosion()
	{
		Instantiate(explosionPrefab, this.transform.position, this.transform.rotation);
		Destroy(this.gameObject);
	}
}
