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
    public static GameManager instance;
  
    public GameOverManager gameOverManager;
    public float scrollspeed = 1f;
   
    // Start is called before the first frame update

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        gameOverManager = FindObjectOfType<GameOverManager>();
    }
    public void GameOver()
    {
        Debug.Log("Game Over");
        gameOverManager.ShowGameOver();
    }
    public void AddScore(int amount) 
    {
        score += amount;
        Debug.Log("Score");
    }
    

    
    // Update is called once per frame
   
}
