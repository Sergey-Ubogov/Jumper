
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 cameraOffset;

    [Range(0.01f, 1.0f)]
    public float smoothFactor = 0.2f;
    void Start()
    {
        cameraOffset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        var newPos = player.transform.position + cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor);
    }
}
