using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 3; // Lượng máu của player
    public GameObject explosionPrefab; // Kéo thả Prefab vụ nổ vào đây

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
    }
}