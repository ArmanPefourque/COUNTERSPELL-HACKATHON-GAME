using UnityEngine;
using Pathfinding;
using System.Collections.Generic;
using System.IO;

public class BossEnemy : MonoBehaviour
{
    public int health;
    public float speed;
    public GameObject sm;
    [SerializeField] private GameObject target;
    public List<GameObject> flors = new List<GameObject>();
    public SanityScript ss;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sm = GameObject.FindGameObjectWithTag("health bar");
        ss = sm.GetComponent<SanityScript>();
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update() {

        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);

        if (health == 0)
        {
            Destroy(gameObject);
            ss.AddTrauma(1);
        }

    }
}