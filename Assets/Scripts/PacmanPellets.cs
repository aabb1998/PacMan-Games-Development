﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacmanPellets : MonoBehaviour
{

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.gameObject.tag == "pacman") {
            Destroy(collider.gameObject);
            Debug.Log("Destroyued");
        }
    }


}
