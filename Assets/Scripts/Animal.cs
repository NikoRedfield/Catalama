using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : DestructibleObject {

    [SerializeField]
    private int dmg;

    public Animal()
    {
        Pv = 0;
        Dmg = 0;
    }

    public Animal(int pv)
    {
        this.Pv = pv;
        Dmg = 0;
    }

    public Animal(int pv, int dmg)
    {
        this.Pv = pv;
        this.Dmg = dmg;
    }

    public void Hit(DestructibleObject target)
    {
        if (target.Pv > 0)
        {
            target.Pv -= Dmg;
            Debug.Log("PV restants : " + target.Pv);
        } else if(target.Pv <= 0)
        {
            // Game over

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Objective"))
        {
            // The objective is necessarily a DestructibleObject
            Hit(collision.gameObject.GetComponent<DestructibleObject>());
        }
        if (collision.gameObject.tag.Equals("Player"))
        {
            //Player is tmp consider a DestructibleObject
            Hit(collision.gameObject.GetComponent<DestructibleObject>());
        }
    }

    // ------------ Getter & Setter methods

    public int Dmg
    {
        get { return dmg; }
        set { dmg = value; }
    }
}
