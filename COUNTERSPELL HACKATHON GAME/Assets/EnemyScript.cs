using UnityEngine;
using Pathfinding;

public class EnemyScript : MonoBehaviour
{
    public GameObject[] floors;
    public string first = "hi";
    private AIPath path;
    [SerializeField] private float moveSpeed;
    [SerializeField] private Transform target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        path = GetComponent<AIPath>();
    }

    // Update is called once per frame
    void Update()
    {
               if (first == "hi"){
            first = "bye";
        floors = GameObject.FindGameObjectsWithTag("floor");
               
        transform.position = floors[Random.Range(0, floors.Length)].transform.position;
        }
        path.maxSpeed = moveSpeed;
        path.destination = target.position;
        
    }
}
