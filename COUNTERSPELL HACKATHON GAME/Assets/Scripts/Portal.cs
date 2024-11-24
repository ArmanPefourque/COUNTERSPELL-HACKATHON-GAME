using UnityEngine;

public class Portal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player")) {
            col.transform.position = new Vector3(500, 500, 0);
        }
    }
}
