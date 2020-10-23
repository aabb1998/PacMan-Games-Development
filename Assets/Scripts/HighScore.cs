using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text highScore;
    public Text score;

    public Text timeHighScore;
    public Text timeScore;




    void Start() {
        highScore.text = "Score: " + PlayerPrefs.GetInt("Highscore", 130).ToString();
        timeHighScore.text = "Time: " + PlayerPrefs.GetString("Timescore", "01:12:23").ToString();
        

    }

    public void updateScore () {
        int highscore = 10;
        //Text time = System.DateTime;
        score.text = "Score: " + highscore.ToString();

        PlayerPrefs.SetInt("Highscore", highscore);

        string timehighscore = "01:23:54";
        timeScore.text = "Time: " + timehighscore;
        PlayerPrefs.SetString("Timescore", timehighscore);


    }





}
