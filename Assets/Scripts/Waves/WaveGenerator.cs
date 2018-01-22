using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveGenerator : MonoBehaviour {

    public Wave[] waves;
    public int delayBetwenWaves;

    private int currentWave;
    private bool won;
    private int timer;
    private bool started;
    

	// Use this for initialization
	void Start () {
        currentWave = 0;
        timer = 0;
        won = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(currentWave != waves.Length - 1 && waves[currentWave].IsOver() && EnemiesLeft() && started)
        {
            if(timer > delayBetwenWaves)
            {
                Debug.Log(currentWave);
                waves[currentWave].gameObject.SetActive(false);
                currentWave++;
                waves[currentWave].gameObject.SetActive(true);
                timer = 0;
            }
            else
            {
                timer++;
            }
            
        }
        else
        {
            if (currentWave == waves.Length - 1 && waves[currentWave].IsOver() && !won)
            {
                Win();
                won = true;
            }
        }
	}


    public void StartWave()
    {
        started = true;
        waves[currentWave].gameObject.SetActive(true);
    }

    bool EnemiesLeft()
    {
        if(GameObject.FindGameObjectsWithTag("Enemy").Length > 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public int CurrentWaveNumber()
    {
        if (started)
        {
            return this.currentWave + 1;
        }
        else
        {
            return 0;
        }
    }

    public int MaxWaves()
    {
        return waves.Length;
    }

    void Win()
    {
        Debug.Log("You won this set of waves");
    }
}
