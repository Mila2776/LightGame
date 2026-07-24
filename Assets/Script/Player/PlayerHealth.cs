using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public RespawnManager respawnManager;

    public int MaxHealth = 3;
    public int CurrentHealth = 0;
    
    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        /*測試
        if (Input.GetKeyDown(KeyCode.K))
        {
            TakeDamage(1); 
        }*/
    }

    public void TakeDamage(int damage) 
    {
        CurrentHealth -= damage;

        Debug.Log("玩家受到傷害，目前HP：" + CurrentHealth);

        if (CurrentHealth <= 0) 
        {
            Die();
        }

    }

    public void Die()
    {
        respawnManager.RespawnPlayer();

        CurrentHealth = MaxHealth;

    }
}
