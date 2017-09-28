using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AnimationDoor : MonoBehaviour {

    public float waitTime = 10f;
    private bool increaseTimer = true;
    private bool animation;


    float timer;

    // Use this for initialization
    void Start ()
    {
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        if (increaseTimer)
        {
            timer += Time.deltaTime;
            if (timer > waitTime)
            {
                this.onTimer();
                this.increaseTimer = false;
            }
        }
    }

    void onTimer()
    {
        //this.GetComponent<Animator>().enabled = true;
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "key")
        {
            this.GetComponent<Animator>().enabled = true;
            Debug.Log("teste");
        }
    }
}
