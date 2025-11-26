using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Color meshColor = new Color(0.6588f, 0.1411f, 0.1451f, 1f);
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<MeshRenderer>().material.color = meshColor;
            gameObject.tag = "Hit";
        }
    }
}
