using UnityEngine;

public class DroneController : MonoBehaviour
{
    private Drone drone;
    public float speed = 2f;
    public float moveSpeed = 1f;
    public Vector2 turn;
    Rigidbody rb;
    public Transform gunTransform;
    public GameObject bulletPrefab;
    public float firerate = 5f;
    public float waittillNextFire = 0.0f;

    void Start()
    {
        drone = GetComponent<Drone>();
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void ShootingBullets()
    {
        if(waittillNextFire <= 0.0f)
        {
            Instantiate(bulletPrefab, gunTransform.position, gunTransform.rotation);
            waittillNextFire = 0.2f;
        }
        waittillNextFire -= 1 * Time.deltaTime;
    }
    void Update()
    {
        turn.x += Input.GetAxis("Mouse X");
        turn.y += Input.GetAxis("Mouse Y");

        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate movement directiqon
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Apply the movement direction to the drone's Rigidbody with constant velocity
        rb.velocity = transform.forward * moveSpeed;

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            drone.Move(speed);
        }

        if (Input.GetKey(KeyCode.Q))
            ShootingBullets();
    }


}
