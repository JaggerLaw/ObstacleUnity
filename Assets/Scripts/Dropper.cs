using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float timeSinceGameStart = 0.0f;
    public Rigidbody rigidbody;
    [SerializeField] float timeForFall = 3f;
    void Start()
    {
        Debug.Log("The game has started");
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceGameStart = Time.time;

        if(timeSinceGameStart >= timeForFall)
        {
            rigidbody.useGravity = true;
        }
    }
}
