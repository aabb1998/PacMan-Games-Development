using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitOnClick : MonoBehaviour
{
    // Start is called before the first frame update
    public void ExitGame() {
        Application.Quit();
        Debug.Log("Game is exiting!");
    }

    public void OnMouseClick() {
        Application.LoadLevel("StartScene");
    }

}
