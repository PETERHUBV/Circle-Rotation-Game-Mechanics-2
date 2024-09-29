using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour

{
    public  float score = 0;
    public float scrollspeed = 1f;
    public Text scoretext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        //Score
        scoretext.text = "" + score;

        //Collectible
        void OnTriggerEnter(Collider other)
        {
        
            if (other.CompareTag("Player"))
            {
               score += 1;
                Destroy(gameObject);
                //obstacle
                void OnTriggerEnter(Collider other)
                {
                    if (other.CompareTag("Player"))
                    {
                        Debug.Log("Game Over");
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                    }
                }

            }
        }

    }
}
