using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{

    [SerializeField] Transform player;
    Vector3 playerPos;
    public float speedOfProjectile = 20.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPos = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPos, speedOfProjectile * Time.deltaTime);
        
    }

    void DestroyWhenReached()
    {
        if(transform.position == playerPos)
        {
            Destroy(gameObject);
        }
    }
}
