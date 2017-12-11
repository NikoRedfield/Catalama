using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleObject : MonoBehaviour {
    
    [SerializeField]
    private int pv;

    public DestructibleObject()
    {
        pv = 0;
    }

    public DestructibleObject(int pv)
    {
        this.pv = pv;
    }

    private 

	// Use this for initialization
	void Start () {
		
	}
	
}
