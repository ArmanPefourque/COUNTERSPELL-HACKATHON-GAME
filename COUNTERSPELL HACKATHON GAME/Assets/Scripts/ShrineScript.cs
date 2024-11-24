using System;
using UnityEngine;

public class ShrineScript : MonoBehaviour
{
    public Color normalColor;
    public Color activatedColor;

    public static int shrinesLeft;

    // Update is called once per frame
    void Start()
    {
        GetComponent<SpriteRenderer>().color = normalColor;
        shrinesLeft += 1;
    }

    private void Update()
    {
        Debug.Log(shrinesLeft);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player"){
            GetComponent<SpriteRenderer>().color = activatedColor;
            shrinesLeft -= 1;

            if (shrinesLeft <= 0) {
                GameObject.FindGameObjectWithTag("Portal").GetComponent<SpriteRenderer>().enabled = true;
                GameObject.FindGameObjectWithTag("Portal").GetComponent<CircleCollider2D>().enabled = true;
            }
        }
    }
}
