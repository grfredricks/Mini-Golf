using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Transform centerPoint; // The center point of the circular movement
    public float radius = 2f; // Radius of the circular path
    public float speed = 1f; // Speed of the circular movement

    private float angle; // Tracks the current angle

    void Update()
    {
        // Increment the angle based on speed
        angle += speed * Time.deltaTime;

        // Calculate the new position in a circular path
        float x = Mathf.Cos(angle) * radius;
        float z = Mathf.Sin(angle) * radius;

        // Update the platform's position
        transform.position = new Vector3(centerPoint.position.x + x, transform.position.y, centerPoint.position.z + z);
    }
}
