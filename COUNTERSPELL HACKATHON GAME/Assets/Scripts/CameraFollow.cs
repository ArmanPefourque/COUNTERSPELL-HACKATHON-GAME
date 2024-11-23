using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float smooth;
    public Transform player;
    public Vector3 offset;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void FixedUpdate()
    {
        float xchange = (transform.position.x - player.transform.position.x)/smooth;
        float ychange = (transform.position.y - player.transform.position.y)/smooth;
        transform.position -= new Vector3 (xchange,ychange,0);
    
    }
}
 