﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacmanPellets : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D co) {
        if (co.name == "pacman") {
            Destroy(gameObject);
        }
    }
}
