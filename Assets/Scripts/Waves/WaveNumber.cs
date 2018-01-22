using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveNumber : MonoBehaviour {

    private Text mtext;
    private int wave;
    private int maxWave;
    private WaveGenerator waveGenerator;

	// Use this for initialization
	void Start () {
        waveGenerator = GameObject.Find("WavesManager").GetComponent<WaveGenerator>();
        mtext = this.GetComponent<Text>();
        wave = 0;
        maxWave = waveGenerator.MaxWaves();
        mtext.text = "Vague " + wave + " / " + maxWave;
	}
	
	// Update is called once per frame
	void Update () {
        wave = waveGenerator.CurrentWaveNumber();
        maxWave = waveGenerator.MaxWaves();
        mtext.text = "Vague " + wave + " / " + maxWave;
    }
}
