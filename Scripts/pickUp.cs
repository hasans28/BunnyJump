using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pickUp : MonoBehaviour
{
    private int scoreCount = 0;
    public Text scoreText;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "carrot") {
            collision.transform.position = new Vector2(collision.transform.position.x - 20, collision.transform.position.y);
            scoreCount++;
            scoreText.text = "" + scoreCount;
            PlayerPrefs.SetInt("Score", scoreCount);
            if (scoreCount > PlayerPrefs.GetInt("Highscore", 0)) {
                PlayerPrefs.SetInt("Highscore", scoreCount);
            }
        }

        if (collision.gameObject.tag == "cactus")
        {
            SceneManager.LoadScene(2);
        }
    }
}
