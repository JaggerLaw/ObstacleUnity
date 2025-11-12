using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] float speedValue =  10.0f;
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speedValue;
        float YValue = 0.0f;
        float ZValue = Input.GetAxis("Vertical") * Time.deltaTime * speedValue;
        transform.Translate(xValue, YValue, ZValue);
    }
}
