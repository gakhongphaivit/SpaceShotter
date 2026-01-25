using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shootingInterval;
    private float lastBulletTime;

    // Singleton pattern
    public static PlayerShooting instance; 
    
    public int weaponPower = 1;
    public int maxweaponPower = 4;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            // SỬA LỖI 1: Thêm dấu trừ (-) vào giữa Time.time và lastBulletTime
            if (Time.time - lastBulletTime > shootingInterval) 
            {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }
    }

    private void ShootBullet()
    {
        // SỬA LỖI 2: Sửa 'bulletPrefabs' thành 'bulletPrefab' (bỏ chữ s)
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }
}