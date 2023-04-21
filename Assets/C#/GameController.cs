using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public Text scoreText;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "score:" + score;
    }


    public void AddScore()
    {
        score += 100;
        scoreText.text = "score:" + score;

    }
    public void OnClick()
    {
        SceneManager.LoadScene("Main");
    }
    public void TitleButton()
    {
        SceneManager.LoadScene("title");
    }
}
