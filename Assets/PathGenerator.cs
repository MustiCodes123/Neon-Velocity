using UnityEngine;

public class GameObjectManager : MonoBehaviour
{
    // Game object prefab to spawn
    public GameObject gameObjectPrefab;

    // Z-coordinate at which to spawn the object
    public float spawnZ = 30f;

    // Reference to the player's transform
    private Transform playerTransform;

    // Flag to track if the object has been spawned
    private bool objectSpawned = false;

    void Start()
    {
        // Find the player's transform by tag
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // Check if the object has not been spawned and the player has moved forward enough
        if (!objectSpawned && playerTransform.position.z >= spawnZ)
        {
            // Spawn the object
            SpawnGameObject();

            // Set the flag to true to prevent spawning again
            objectSpawned = true;
        }
    }

    void SpawnGameObject()
    {
        // Instantiate the game object at the specified position
        Instantiate(gameObjectPrefab, new Vector3(0f, 0f, spawnZ), Quaternion.identity);
    }
}
