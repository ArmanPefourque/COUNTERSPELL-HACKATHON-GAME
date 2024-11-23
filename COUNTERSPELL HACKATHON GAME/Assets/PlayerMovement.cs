using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject[] floors;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    private Vector2 movement;

    private string first = "hi";

    void Start()
    {
        
      
    }

    void Update()
    {
        if (first == "hi"){
            first = "bye";
        floors = GameObject.FindGameObjectsWithTag("floor");

        transform.position = floors[Random.Range(0, floors.Length)].transform.position;
        }
        // Get input from the player
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }

    void FixedUpdate()
    {
        
       
        // Move the player

    }
}
