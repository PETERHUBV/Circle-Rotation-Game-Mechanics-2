using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionofGame : MonoBehaviour
{
    public int Score;
    public bool Obstacle;
    public float speed = 2f;


    public Vector3 MovementDirection;

    void Start()
    {

        MovementDirection = Random.Range(0, 2) == 0 ? Vector3.right : Vector3.left;
    }

    void Update()
    {

        transform.Translate(MovementDirection * speed * Time.deltaTime);


        //  if (transform.position.x < -10f || transform.position.x > 10f)
        //  {

        // }

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
                    }

                }
                else
                {
                    Debug.LogError("GameManager not working");
                }
            }
        }
    }
