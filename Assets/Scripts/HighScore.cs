using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    
    public Text score;
    //public Text time;
    public Text highScore;
    public Text bestTime;

    void Start() {
        highScore.text = "Score: " + PlayerPrefs.GetInt("Highscore", 30).ToString();
    }

    public void updateScore () {
        int highscore = 10;
        //Text time = System.DateTime;
        score.text = "Score: " + highscore.ToString();

        PlayerPrefs.SetInt("Highscore", highscore);

    }

}
