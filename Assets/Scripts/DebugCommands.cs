﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugCommands : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("p"))
        {
            foreach(GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy"))
            {
                Destroy(enemy);
            }
        }
	}
}
