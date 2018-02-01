using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : DestructibleObject
{

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
            // Enemies are destroyed when damaging the objective
            if (target.gameObject.tag.Equals("Objective"))
            {
                gameObject.SetActive(false);
            }
            target.Pv -= Dmg;
        }
        else if (target.Pv <= 0)
        {
            if (target.gameObject.tag.Equals("Enemy"))
            {
                target.gameObject.SetActive(false);
            }
            else if (target.gameObject.tag.Equals("Objective"))
            {
                target.gameObject.SetActive(false);
            }
            else
            {
                // Game over
            }

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Objective"))
        {
            // The objective is necessarily a DestructibleObject
            Hit(collision.gameObject.GetComponent<DestructibleObject>());
        }
        if (collision.gameObject.tag.Equals("Player"))
        {
            //Player is tmp consider a DestructibleObject
            Hit(collision.gameObject.GetComponent<DestructibleObject>());
        }
        if (gameObject.tag.Equals("Player") && collision.gameObject.tag.Equals("Enemy") && Input.GetMouseButton(0))
        {
            Hit(collision.gameObject.GetComponent<DestructibleObject>());
            Debug.Log("-50 pv!");
        }
    }

    // ------------ Getter & Setter methods

    public int Dmg
    {
        get { return dmg; }
        set { dmg = value; }
    }
}
