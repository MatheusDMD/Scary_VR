using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour {
    bool isOpening = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (this.isOpening)
        {
            transform.localPosition += new Vector3(0.1F, 0, 0);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        this.isOpening = true;
    }
}
