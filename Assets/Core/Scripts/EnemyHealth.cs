using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int StartingHealth = 3;

    int CurrentHealth;

    void Awake()
    {
        CurrentHealth = StartingHealth;
    }

    public void TakeDamage(int amount)
    {
        CurrentHealth -= amount;

        if (CurrentHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
