using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    [Range(0.0f, 1f)]
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        smoothedPosition.x = 0;
        transform.position = smoothedPosition;    
    }

}
