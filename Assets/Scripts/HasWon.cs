using UnityEngine;
using TMPro;

public class HasWon : MonoBehaviour
{
    [SerializeField] public TextMeshPro winText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        winText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ShowWin();
        }
    }

    public void ShowWin()
    {
        winText.gameObject.SetActive(true);
    }
}
