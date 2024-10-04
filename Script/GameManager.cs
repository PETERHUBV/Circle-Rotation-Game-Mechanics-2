using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
public class GameManager : MonoBehaviour

{
    public  float score = 0;
    public Text ScoreText;
    public GameOverManager gameOverManager;
    public float scrollspeed = 1f;
   
    // Start is called before the first frame update

 
    void Start()
    {
        gameOverManager = FindObjectOfType<GameOverManager>();
        if(ScoreText == null)
        {


        }
        UpdateScoreText();
    }
    public void GameOver()
    {
        Debug.Log("Game Over");
        gameOverManager.ShowGameOver();
    }
    public void AddScore(int amount) 
    {
        score += amount;
        Debug.Log("Score" + score);
        UpdateScoreText();
    }
    public void UpdateScoreText()
    {
        if (ScoreText == null)
        {


        }
        ScoreText.text = "" + score;
    }

    
    // Update is called once per frame
   
}
