using UnityEngine;

public class scorer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int score = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Hit"))
        {    
            score++;
            Debug.Log("You've hit something " + score + " times");
        }
    }
}
