using Unity.VisualScripting;
using UnityEngine;

public class Health : MonoBehaviour
{

    public Hiding HideScript;
    public int currentHealth;
    public int maxHealth;
    [SerializeField] float recovery;
    [SerializeField] GameObject GameOverScreen;
   public bool CanTakeDamage;
    [SerializeField] HPChange hpc;
    
    public void Awake()
    {
        HideScript = FindAnyObjectByType<Hiding>();
        hpc = FindFirstObjectByType<HPChange>();
        GameOverScreen = GameObject.FindWithTag("GameOver");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        GameOverScreen.SetActive(false);
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
                if (HideScript.isHiding == false)
                {
                    Invoke("SetTrue", recovery);
                    print("can take damage");
                }
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
