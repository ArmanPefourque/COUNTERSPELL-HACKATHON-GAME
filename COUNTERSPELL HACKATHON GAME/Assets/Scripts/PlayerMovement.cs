using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int sanity;
    public GameObject[] floors;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    private Vector2 movement;
    //public static bool isMoving = false;

    private string first = "hi";

    void Start()
    {
        
      
    }

    void Update()
    {
        if (first == "hi"){
            first = "bye";
            //Testing...
            //TODO: will change later
        floors = GameObject.FindGameObjectsWithTag("floor");

        transform.position = floors[Random.Range(0, floors.Length)].transform.position;

        //transform.position = new Vector3(500, 500, 0);
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
