using UnityEngine;

public class DroneController : MonoBehaviour
{
    public float speed = 5f; // Adjust speed as needed
    public float sensitivity = 2f; // Mouse sensitivity
    private float rotationX = 0f;

    void Update()
    {
        // Forward movement
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        // Mouse rotation
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        rotationX += mouseX;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f); // Clamp rotation to prevent flipping

        transform.rotation = Quaternion.Euler(0f, rotationX, 0f);
    }
}
