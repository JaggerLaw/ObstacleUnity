using System;
using UnityEngine;

public class PressMovement : MonoBehaviour
{
    Vector3 pressPos;
    [SerializeField] float speed = -1.0f;
    bool down = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pressPos = transform.position;
        Debug.Log("PressPosition: " + pressPos);
    }

    // Update is called once per frame
    void Update()
    {
        if (down)
        {
            if(transform.position.y < 0)
            {
                down = false;
            }

            transform.Translate(0, -1 * speed * Time.deltaTime, 0);
        } else
        {
            if(transform.position.y > 6)
            {
                down = true;
            }
            transform.Translate(0, speed * Time.deltaTime, 0);

        }
    }
}
