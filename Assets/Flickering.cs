using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flickering : MonoBehaviour {
    Light testLight;
    public float minWaitTime;
    public float maxWaitTime;

    // Use this for initialization
    void Start() {
        testLight = this.GetComponent<Light>();
        StartCoroutine(Flashing());
    }

    // Update is called once per frame
    void Update() {

    }
    IEnumerator Flashing()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));
            testLight.enabled = !testLight.enabled;

        }
    }
}   
