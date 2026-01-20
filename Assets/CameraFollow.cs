using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;   // tomobil
    public Vector3 offset;     // المسافة بين camera و tomobil
    public float smoothSpeed = 5f;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothPosition;

        transform.LookAt(target);
    }
}
