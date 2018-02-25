using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanObject : MonoBehaviour {


    public Camera camera;
    public int range;
    public GameObject MinionNotSpawned;
    GameObject MinionNS = null;  /*(have to be outside the Update() )*/

    int spawned = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        Vector3 rayOrigin = camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;


        if (Physics.Raycast(rayOrigin, camera.transform.forward, out hit, range))
        {
            //Debug.Log (hit.point);
            if (spawned == 0)
            {
                MinionNS = Instantiate(MinionNotSpawned, hit.point, Quaternion.identity);
                spawned = 1;
            }
        }

        if (spawned == 1)
        {
            Debug.Log("1");

            //GameObject.FindWithTag("MinionNS").transform.position = hit.point;
            MinionNS.transform.position = hit.point;
        }
    }
}
