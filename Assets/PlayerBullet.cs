using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    private Transform target;
    public float speed = 70f; // Speed of the bullet

    public GameObject impactEffect; // Effect to show on impact

    private void Update()
    {
        if (target == null)
        {
            Destroy(gameObject); // Destroy the bullet if the target is null
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World); // Move the bullet towards the target
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            // Destroy the enemy GameObject
            Destroy(other.gameObject);

            // Instantiate impact effect
            GameObject effectInstance = Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(effectInstance, 2f); // Destroy impact effect after 2 seconds

            Destroy(gameObject); // Destroy the bullet after hitting the target
        }
    }

        public void Seek(Transform _target)
    {
        target = _target; // Set the target for the bullet to seek
    }

    private void HitTarget()
    {
        GameObject effectInstance = Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectInstance, 2f); // Destroy impact effect after 2 seconds

        // Deal damage to the target or perform any other desired action
        // For example, you might have a Health script attached to the player that decreases health when hit by a bullet.

        Destroy(gameObject); // Destroy the bullet after hitting the target
    }
}
