using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{

    public AudioClip menu;
    public AudioSource audio;

    // Start is called before the first frame update
    public void PlayLevel1() {
        SceneManager.LoadScene("SampleScene");
    }

    // void Start() {
    //     audio = GetComponent<AudioSource>();
    //     audio.clip = menu;
    //     audio.loop = true;
    //     audio.Play();
    // }
}
