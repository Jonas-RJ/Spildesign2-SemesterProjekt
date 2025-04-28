using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int currentHealth;
    [SerializeField] private int maxHealth;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
    }

    void TakeDamage()
    {
        currentHealth--;
        
        
        if (currentHealth <= 0)
        {
            //Play captured animation/music
            //Display Game Over
        }
    }
}
