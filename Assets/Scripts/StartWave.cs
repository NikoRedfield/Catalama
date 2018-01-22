using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartWave : MonoBehaviour {

    public Text mtext;

    private bool isReady;
    private WaveGenerator waveGenerator;
    private bool done = false;

	void Start () {
        waveGenerator = GameObject.Find("WavesManager").GetComponent<WaveGenerator>();
        isReady = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(isReady && Input.GetKeyDown("e"))
        {
            mtext.enabled = false;
            isReady = false;
            waveGenerator.StartWave();
            done = true;

        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (!done)
        {
            isReady = true;
            mtext.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!done)
        {
            isReady = false;
            mtext.enabled = false;
        }
    }
}
