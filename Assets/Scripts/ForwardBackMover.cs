using UnityEngine;

public class ForwardBackMover : MonoBehaviour
{
    Vector3 startingPosition;
    //the starting z value for this block is -21 and to go further is more negative therefore minus z value to move forward at the start
    float zValue = 2.0f;
    float targetPosition = -37.0f;
    bool forward = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startingPosition = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (forward)
        {
            transform.Translate(0, 0, -zValue * Time.deltaTime);
            
            //target position is used for the local position of this obstacle, needs to be changed later to be used for other obstacles
            if(transform.localPosition.z < targetPosition)
            {
                forward = false;
            }
        } 
        else
        {    
            transform.Translate(0, 0, zValue * Time.deltaTime);
            
            if(transform.localPosition.z > startingPosition.z)
            {
                forward = true;
            }
        }
        
    }
}
