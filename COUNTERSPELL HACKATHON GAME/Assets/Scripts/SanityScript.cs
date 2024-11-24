using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SanityScript : MonoBehaviour
{
    public List<Sprite> sprites = new List<Sprite>();
    public int sanity = 0;
    public int time = 0;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
                if (sanity >= 16){
                    time +=1;

        }
            if (time > 100){
           SceneManager.LoadScene("DeadScene");
            }
    }
    public void AddTrauma(int number)
    {
        sanity += number;
        GetComponent<Image>().sprite  = sprites[sanity];

    }
    
}
