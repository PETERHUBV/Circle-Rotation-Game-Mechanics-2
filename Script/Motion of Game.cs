using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionofGame : MonoBehaviour
{
    // Start is called before the first frame update
    public int Score;
    public bool Obstacle;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * 2);
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
        void OnTriggerEnter(Collider collision)
        {
            if (collision.CompareTag("Player"))

            {
                GameManager gameManager = FindObjectOfType<GameManager>();
                if (gameManager != null)
                {

                    if (Obstacle)
                    {
                        gameManager.GameOver();
                    }
                    else
                    {

                        gameManager.AddScore(Score);
                        Destroy(gameObject);
                    }
                }
                else
                {
                    Debug.LogError("GameManager not found");
                }
                    
                }
            }
        }
    


        
    

    

