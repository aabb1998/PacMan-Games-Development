using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Teleporter : MonoBehaviour
{

    public Vector3 teleportPoint;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag.Equals("pacman")) {
            if (teleportPoint != null) {
                collision.gameObject.transform.position = teleportPoint;
            }
        }
    }
}
