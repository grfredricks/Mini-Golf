using UnityEngine;

public class Windmill : MonoBehaviour
{
    public float rotationSpeed = 50f; // Speed of rotation in degrees per second

    void Update()
    {
        // Rotate the object around the X-axis
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
