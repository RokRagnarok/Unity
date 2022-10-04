
using UnityEngine;

public class CameraFolow : MonoBehaviour
{
    public Transform player;
    Vector3 offset;
    void Start()
    {
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 trargetPos = player.position + offset;
        trargetPos.x = 0;
        transform.position = trargetPos;
    }
}
