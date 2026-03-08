using UnityEngine;
using System; // Thêm thư viện này để dùng Action

public class Health : MonoBehaviour // Kế thừa từ MonoBehaviour
{
    // [1] Thuộc tính công khai: Prefab nổ và Điểm máu mặc định
    public GameObject explosionPrefab;
    public int defaultHealthPoint;
    public System.Action onDead;

    // [2] Thuộc tính private: Điểm máu hiện tại
    private int healthPoint;

    // Khởi tạo điểm máu khi Start
    private void Start() => healthPoint = defaultHealthPoint;

    // [3] Phương thức xử lý cái chết (đã gộp lại thành 1 hàm duy nhất)
    protected virtual void Die()
    {
        // Tạo hiệu ứng nổ tại vị trí hiện tại
        var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
        
        // Hủy hiệu ứng nổ sau 1 giây
        Destroy(explosion, 1);
        
        // Hủy đối tượng game hiện tại
        Destroy(gameObject);
        
        // Kích hoạt sự kiện onDead khi nhân vật chết
        onDead?.Invoke(); 
    }

    // [4] Phương thức nhận sát thương
    public void TakeDamage(int damage)
    {
        // Nếu máu đã hết, thoát
        if (healthPoint <= 0) return;
        
        // Giảm máu
        healthPoint -= damage;
        
        // Nếu máu hết, gọi Die()
        if (healthPoint <= 0) Die();
    }

    // [5] Khi va chạm trigger, gọi hàm Die()
    public void OnTriggerEnter2D(Collider2D collision) => Die();
}