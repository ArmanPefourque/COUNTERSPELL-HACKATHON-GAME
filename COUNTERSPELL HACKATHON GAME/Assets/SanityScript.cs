using UnityEngine;
using System.Collections.Generic;

public class SanityScript : MonoBehaviour
{
    public List<Sprite> sprites = new List<Sprite>();
    public int sanity = 0;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddTrauma(int number)
    {
        sanity += number;
        GetComponent<SpriteRenderer>().sprite  = sprites[5];
    }
}
