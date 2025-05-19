using Unity.VisualScripting;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;
    [SerializeField] float recovery;
    public GameObject GameOverScreen;
    bool CanTakeDamage;
    [SerializeField] HPChange hpc;
    
    public void Awake()
    {
        hpc = FindObjectOfType<HPChange>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
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
                hpc.Change();
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
            Time.timeScale = 0;
            GameOverScreen.SetActive(true);
        }
    }

    void SetTrue()
    {
        CanTakeDamage = true;
    }
}
