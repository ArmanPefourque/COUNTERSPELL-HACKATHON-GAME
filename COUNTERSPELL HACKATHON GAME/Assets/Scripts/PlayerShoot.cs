using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public float timeBetweenShots;
    private float timeUntilNextShot;

    public GameObject bulletPrefab;
    public float bulletSpeed;

    private void Start()
    {
        timeUntilNextShot = timeBetweenShots;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && timeUntilNextShot <= 0) {
            timeUntilNextShot = timeBetweenShots;
            ShootBullet();
        }

        timeUntilNextShot -= Time.deltaTime;
    }

    void ShootBullet() {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); 
        mousePosition.z = 0; 
        Vector2 direction = (mousePosition - transform.position).normalized; 
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity); 
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.linearVelocity = direction * bulletSpeed;
    }
}
