using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Wall")) {
            Destroy(gameObject);
        }
        if (col.CompareTag("enemy")){
            col.GetComponent<EnemyScript>().health -=1;
            Destroy(gameObject);
        }
    }
}
