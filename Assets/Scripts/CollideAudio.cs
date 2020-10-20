using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideAudio : MonoBehaviour
{

    public AudioClip audioClip;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            GetComponent<AudioSource> ().clip = audioClip;
            GetComponent<AudioSource> ().Play();
            print("There is a collision");
        } else {
            print("There is no collision");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
