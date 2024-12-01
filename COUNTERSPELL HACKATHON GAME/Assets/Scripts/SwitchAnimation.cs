using System.Collections;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
public class SwitchAnimation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Sprite tallChamelon;
    public Sprite shortChamelon;
    void Start()
    {
        StartCoroutine(CycleSprites());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator CycleSprites()
    {
        while (true)
        {
            GetComponent<SpriteRenderer>().sprite = tallChamelon;
            yield return new WaitForSeconds(1);
            GetComponent<SpriteRenderer>().sprite = shortChamelon;
            yield return new WaitForSeconds(1);
        }
        
    }
}
