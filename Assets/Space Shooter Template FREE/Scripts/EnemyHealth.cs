using UnityEngine;

// Kế thừa từ lớp Health
public class EnemyHealth : Health 
{
    // Ghi đè phương thức Die() để thêm logic riêng cho Enemy
    protected override void Die()
    {
        base.Die(); // Gọi phương thức Die() của lớp Health (xử lý nổ, hủy đối tượng)
        Debug.Log("Enemy died"); // Thêm logic riêng
    }
    
    // Các logic khác như explosionPrefab, OnTriggerEnter2D, TakeDamage 
    // đã được tự động kế thừa từ lớp Health.
}