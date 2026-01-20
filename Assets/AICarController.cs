using UnityEngine;

public class AICarController : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 10f;
    public float rotationSpeed = 5f;

    private int currentWaypointIndex = 0;

    void Update()
    {
        if (waypoints.Length == 0) return;

        Transform target = waypoints[currentWaypointIndex];

        Vector3 direction = (target.position - transform.position).normalized;

        Quaternion lookRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            lookRotation,
            rotationSpeed * Time.deltaTime
        );

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        float distance = Vector3.Distance(transform.position, target.position);
        if (distance < 2f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0; // يعاود اللفة
            }
        }
    }
}
