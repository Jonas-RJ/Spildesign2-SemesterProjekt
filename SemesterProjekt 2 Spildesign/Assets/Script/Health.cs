using Unity.VisualScripting;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int currentHealth;
    [SerializeField] private int maxHealth;
    [SerializeField] float recovery;
    public GameObject GameOverScreen;
    bool CanTakeDamage;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
        CanTakeDamage = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            
            if (CanTakeDamage)
            {
                CanTakeDamage = false;
                TakeDamage(); 
                print("damage");
                Invoke("SetTrue", recovery);
            }
        }
    }

    void TakeDamage()
    {
        currentHealth--;
        
        
        if (currentHealth <= 0)
        {
            //Play captured animation/music
            GameOverScreen.SetActive(true);
        }
    }

    void SetTrue()
    {
        CanTakeDamage = true;
    }
}
