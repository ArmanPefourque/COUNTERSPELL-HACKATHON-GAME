using UnityEngine;

public class ShrineScript : MonoBehaviour
{
    public Color normalColor;
    public Color activatedColor;

    // Update is called once per frame
    void Start()
    {
        GetComponent<SpriteRenderer>().color = normalColor;
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player"){
            GetComponent<SpriteRenderer>().color = activatedColor;
        }
    }
}
