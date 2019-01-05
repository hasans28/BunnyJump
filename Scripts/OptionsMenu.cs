using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    public Text score;

    public void LoadGame() {
        SceneManager.LoadScene(1);
    }

    void Update()
    {
        if (score.gameObject.tag == "highScore") {
            score.text = "Highscore: " + PlayerPrefs.GetInt("Highscore", 0);
        }
        if (score.gameObject.tag == "currentScore") {
            score.text = "Score: " + PlayerPrefs.GetInt("Score", 0);
        }
    }
}
