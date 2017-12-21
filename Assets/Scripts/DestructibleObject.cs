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

    // ------------ Getter & Setter methods

    public int Pv
    {
        get { return pv; }
        set { pv = value; }
    }
	
}
