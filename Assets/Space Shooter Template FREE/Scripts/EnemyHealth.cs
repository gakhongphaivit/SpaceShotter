using UnityEngine;

// Kế thừa từ lớp Health
public class EnemyHealth : Health 
{
    // [1] THÊM DÒNG NÀY: Biến static dùng chung để đếm tổng số quái
    public static int LivingEnemyCount;

    // [2] THÊM HÀM NÀY: Khi 1 con quái được sinh ra, cộng 1 vào tổng số
    private void Awake() 
    {
        LivingEnemyCount++;
    }

    // Ghi đè phương thức Die() để thêm logic riêng cho Enemy
    protected override void Die()
    {
        // [3] THÊM DÒNG NÀY: Khi quái chết, trừ đi 1
        LivingEnemyCount--;

        base.Die(); // Gọi phương thức Die() của lớp Health (xử lý nổ, hủy đối tượng)
        Debug.Log("Enemy died"); // Thêm logic riêng
    }
    
    // Các logic khác như explosionPrefab, OnTriggerEnter2D, TakeDamage 
    // đã được tự động kế thừa từ lớp Health.
}