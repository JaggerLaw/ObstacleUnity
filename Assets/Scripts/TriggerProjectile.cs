using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject projectile1;
    [SerializeField] GameObject projectile2;
    void OnTriggerEnter(Collider other)
    {
        if (projectile != null)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                projectile.SetActive(true);
                
                if(projectile1 != null)
                {
                    projectile1.SetActive(true);
                }
                
                if(projectile2 != null)
                {
                    projectile2.SetActive(true);
                }
            }
        }

    }
}
