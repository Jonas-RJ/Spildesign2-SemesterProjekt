using UnityEngine;
using UnityEngine.UI;

public class HPChange : MonoBehaviour
{
    //References, variables and array
    [SerializeField] private Image[] health;
    public Health hp;
    [SerializeField] private int change;
    [SerializeField] private int pool;
    [SerializeField] private int maxPool;
    Image point;
    [SerializeField] Sprite healed;
    [SerializeField] Sprite hurt;

    public void Start()
    {
        pool = hp.maxHealth;
        maxPool = hp.maxHealth;
    }

    public void Change()
    {
        //Sets a new variable to the dice damage
        change = hp.currentHealth;
        //Pool of lost health total
        pool = maxPool - change;

        //For loop where the individual health sprite equal to the pool is set to the red/damaged sprite
        for (int i = 0; i < pool; i++)
        {
            point = health[i];
            point.sprite = hurt;
        }
    }

    public void HealthUIReset()
    {
        foreach (var p in health)
        {
            p.sprite = healed;
        }
    }
}
