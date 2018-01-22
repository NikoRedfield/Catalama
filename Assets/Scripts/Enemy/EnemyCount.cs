using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCount : MonoBehaviour {

    private Text mtext;
    private int i = 0;

	
	void Start () {
        mtext = this.GetComponent<Text>();
        mtext.text = "Enemies: "+i;
	}
	
	// Update is called once per frame
	void Update () {
        i = GameObject.FindGameObjectsWithTag("Enemy").Length;
        mtext.text = "Enemies: " + i;
    }
}
