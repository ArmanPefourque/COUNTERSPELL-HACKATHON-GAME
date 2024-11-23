using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
                    Vector2 moveVector = new Vector2 (Input.GetAxis("Horizontal"),Input.GetAxis("Vertical")) * speed  * Time.deltaTime;
        rb.linearVelocity = moveVector;
    }
    private void LateUpdate() {

    }
}
