using UnityEngine;
using Pathfinding;
using System.Collections.Generic;
using System.IO;

public class EnemyScript : MonoBehaviour
{
    public GameObject sm;
    public GameObject[] floors;
    public string first = "hi";
    private AIPath path;
    public int health;
    [SerializeField] private float moveSpeed;
    [SerializeField] private GameObject target;
    public List<GameObject> flors = new List<GameObject>();
    public SanityScript ss;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sm = GameObject.FindGameObjectWithTag("health bar");
        ss = sm.GetComponent<SanityScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (first == "hi")
        {
            first = "bye";
            floors = GameObject.FindGameObjectsWithTag("floor");

            target = GameObject.FindGameObjectWithTag("Player");
            path = GetComponent<AIPath>();

            foreach (GameObject floor in floors)
            {
                float xdist = floor.transform.position.x - target.transform.position.x;
                float ydist = floor.transform.position.y - target.transform.position.y;
                if (Mathf.Sqrt((xdist * xdist) + (ydist * ydist)) > 10)
                {
                    flors.Add(floor);
                }
            }

            transform.position = flors[Random.Range(0, floors.Length)].transform.position;
        }
        path.maxSpeed = moveSpeed;
        path.destination = target.transform.position;
        if (health == 0)
        {

            Destroy(gameObject);
            ss.AddTrauma(1);
        }

    }
}