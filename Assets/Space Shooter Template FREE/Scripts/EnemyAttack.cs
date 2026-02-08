using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    // Bỏ chữ public đi hoặc thêm [SerializeField] nếu muốn xem
    private EnemyHealth health; 
    public int damage = 1;

    void Start()
    {
        // Tự động tìm script EnemyHealth gắn trên cùng đối tượng này
        health = GetComponent<EnemyHealth>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var playerHealth = collision.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);
            
            // Kiểm tra cho chắc chắn là đã tìm thấy health chưa
            if(health != null)
            {
                health.TakeDamage(1000);
            }
        }
    }
}