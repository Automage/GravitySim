using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapGenerator : MonoBehaviour {

	public GameObject go;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")) {
			GameObject got = Instantiate(go, new Vector3(0f,80f,0f), Quaternion.identity);
			got.GetComponent<Rigidbody>().AddForce(2500f * Vector3.Normalize(new Vector3(Random.Range(-1f,1f), 0f, Random.Range(-1f,1f))));
		} else if (Input.GetKeyDown("p")) {
			GameObject got = Instantiate(go, new Vector3(80f,0f,0f), Quaternion.identity);
			got.GetComponent<Rigidbody>().AddForce(300f * new Vector3(0f, 0f, 10f));
		}
		
	}
}
