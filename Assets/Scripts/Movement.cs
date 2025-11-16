using System;
using UnityEngine;
using UnityEngine.Rendering;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] float speedValue =  10.0f;
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("(WASD) to move");
        Debug.Log("Try to make it to the end");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speedValue;
        float YValue = 0.0f;
        float ZValue = Input.GetAxis("Vertical") * Time.deltaTime * speedValue;
        transform.Translate(xValue, YValue, ZValue);
    }
}
