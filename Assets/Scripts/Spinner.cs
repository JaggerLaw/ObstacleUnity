using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xSpin = 0f;
    [SerializeField] float ySpin = 0.6f;
    [SerializeField] float zSpin = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xSpin, ySpin, zSpin);
    }
}
