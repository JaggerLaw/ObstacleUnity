using System;
using UnityEngine;

public class PressMovement : MonoBehaviour
{
    [SerializeField] float yTransformVal = 2.0f;
    Vector3 startingPosition;
    bool down = true;

    void Start()
    {
        startingPosition = transform.position;
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

            transform.Translate(0, -yTransformVal * Time.deltaTime, 0);
        } else
        {
            if(transform.position.y > startingPosition.y)
            {
                down = true;
            }
            transform.Translate(0, yTransformVal * Time.deltaTime, 0);

        }
    }
}
