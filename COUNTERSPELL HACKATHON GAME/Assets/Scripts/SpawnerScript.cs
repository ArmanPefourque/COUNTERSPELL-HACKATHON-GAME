using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    private int timer;
    public int rate;
    public GameObject enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer ++;
        if (timer > rate){
            timer = 0;
            Instantiate(enemy);
        }
    }
}
