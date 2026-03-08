using UnityEngine;
using System; // Bổ sung thư viện này để dùng Action

public class PlayerHealth : MonoBehaviour
{
    public int health = 3; // Lượng máu của player
    public GameObject explosionPrefab; // Kéo thả Prefab vụ nổ vào đây
    
    // BỔ SUNG: Khai báo sự kiện báo tử
    public System.Action onDead; 

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Tạo vụ nổ tại vị trí của Player
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        
        // Hủy đối tượng Player
        Destroy(gameObject);
        
        // BỔ SUNG CỰC QUAN TRỌNG: Phát tín hiệu cho BattleFlow biết tàu đã nổ!
        onDead?.Invoke();
    }
}