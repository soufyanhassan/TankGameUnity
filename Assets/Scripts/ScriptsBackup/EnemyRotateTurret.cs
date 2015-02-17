﻿using UnityEngine;
using System.Collections;

public class EnemyRotateTurret : BaseRotateTurret {
    public Transform player;
	// Use this for initialization
   
	// Update is called once per frame
	override protected void Update () {

        if (player != null)
        {
            targetPos = player.position - Vector3.up * 0.11f; //(0,0.11,0)
            base.Update();
        }
	}
}
