using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float timeSinceGameStart = 0.0f;
    public new Rigidbody rigidbody;
    public MeshRenderer meshRenderer;
    [SerializeField] float timeForFall = 3f;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
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
            meshRenderer.enabled = true;
        }
    }
}
