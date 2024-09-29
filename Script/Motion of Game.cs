using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionofGame : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 4f;
    public float movedistance = 3f;
    public Vector3 Position;


  void Start()
    {
        Position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Position.x + Mathf.Sin(Time.time * speed) * movedistance;
        transform.position = new Vector3(direction, transform.position.y, transform.position.x);
    }
}
