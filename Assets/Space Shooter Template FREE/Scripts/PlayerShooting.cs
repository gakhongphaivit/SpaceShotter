using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefabs;
    public float shootingInterval;
    private float lastBulletTime;
    public Vector3 bulletOffset;

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
            if (Time.time - lastBulletTime > shootingInterval) 
            {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }
    }

    private void ShootBullet()
    {
        var bullet = Instantiate (bulletPrefabs, transform.position + bulletOffset, transform.rotation);
    }
}