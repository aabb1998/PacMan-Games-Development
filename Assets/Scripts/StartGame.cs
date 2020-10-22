using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public Text startText;
    public float time = 2;

    void Start()
    {
        StartCoroutine(Countdown(4));
    }
   
    IEnumerator Countdown(int seconds)
    {
        int count = seconds;
       
        while (count > 0) {
           
            // display something...
            yield return new WaitForSeconds(1);
            count --;
            startText.text = count.ToString();
            

        }

        if (count == 0) {
            startText.text = "GO!";
        }
       
        // count down is finished...
        StartGameA();
    }

    IEnumerator Destroy() {
        yield return new WaitForSeconds(time);
        Destroy(startText);
    }


 
    void StartGameA()
    {
        // do something...
    }
}
