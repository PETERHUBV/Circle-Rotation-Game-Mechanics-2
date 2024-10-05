using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleRotation : MonoBehaviour
{
    public float Circlespeed;
    public float switchTime;
    public Transform gameobject;


    public bool Clockwise = true;

    public float timeelapsed = 0f;


    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {



        timeelapsed += Time.deltaTime;

        if (timeelapsed >= switchTime)
        {
            timeelapsed = 0f;
        }
        // Switch the rotation direction
        if (Input.GetMouseButtonDown(0))
        {
            Clockwise = !Clockwise;
        }

        float direction = Clockwise ? 1f : -1f;

        transform.Rotate(Vector3.forward, Circlespeed * direction * Time.deltaTime);


        Debug.Log("Rotation");
    }
      public void OnTriggerEnter2D(Collider2D other)
        {


            if (other.CompareTag("Collectible"))
            {
                GameManager gameManager = FindObjectOfType<GameManager>();
                if (gameManager != null)
                {
                MotionofGame collectible = other.GetComponent<MotionofGame>();
                if (collectible != null)
                {

                    gameManager.AddScore(collectible.score);
                    Destroy(other.gameObject);
                }
                }
            }
            else if (other.CompareTag("Obstacle"))
            {
                GameManager gameManager = FindObjectOfType<GameManager>();
                if (gameManager != null)

                {
                    gameManager.GameOver();
                    Destroy(gameObject);
                }
            }
        }
    }


        
    


