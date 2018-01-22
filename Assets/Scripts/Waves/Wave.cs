using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour {

    public int numberOfEnemies = 0;
    public int spawnDelay = 0;
    public Transform[] spawnLocations;
    public GameObject enemy;

    private int currentEnemies;
    private bool over = false;
 

	
	void Start () {
        currentEnemies = 0;
        InvokeRepeating("Spawn", spawnDelay, spawnDelay);  //Spawn an enemy every spawnDelay seconds

    }
	

	void Update () {
        if (currentEnemies >= numberOfEnemies)   //max number of enemies reached
        {
            CancelInvoke();
            over = true;
        }
    }

    //Spawn one enemy
    void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnLocations.Length);
        Instantiate(enemy, spawnLocations[spawnPointIndex].position, spawnLocations[spawnPointIndex].rotation);
        currentEnemies++;
    }

    public bool IsOver()
    {
        return this.over;
    }
}
