using UnityEngine;

public class MonsterAttack : MonoBehaviour
{
    public int Damage = 1;

    public float AttackCooldown = 1f;

    public Candle candle;

    private float lastAttackTime;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Attack(collision.gameObject);
        }
    }


    void Attack(GameObject player)
    {
        if (!candle.IsLightOn)
        {
            Debug.Log("ÄúÀëº¶·À¡A©Çª«µLªk§ðÀ»");
            return;
        }


        if (Time.time < lastAttackTime + AttackCooldown)
        {
            return;
        }


        PlayerHealth health =
            player.GetComponent<PlayerHealth>();


        if (health != null)
        {
            health.TakeDamage(Damage);

            Debug.Log("©Çª«§ðÀ»ª±®a");
        }


        lastAttackTime = Time.time;
    }
}
