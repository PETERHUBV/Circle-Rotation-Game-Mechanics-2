using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleRotation : MonoBehaviour
{
    public float Circlespeed;
    public float switchTime;
    public Transform Rotation;
    public Vector3 DefPos;
    public bool Clockwise = true;
    public bool stopped = false;
    public float timeelapsed = 0f;


    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {

        {

        }

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
        void OnTriggerEnter(Collider other)
        {


            if (other.CompareTag("") && !stopped)
            {
                StopMovement(other.gameObject);
            }
            void StopMovement(GameObject target)
            {
               
                Rigidbody2D rb = target.GetComponent<Rigidbody2D>();
                if (rb != null)
                {
                    rb.velocity = Vector2.zero; 
                    rb.isKinematic = true; 

                }
                stopped = true;
            }
        }
    }
}
    

