using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] float movementX = 0.0f;
    [SerializeField] float movementY = 0.009f;
    [SerializeField] float movementZ = 0.0f;
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movementX, movementY, movementZ);
    }
}
