using System.Collections.Generic;
using UnityEngine;

public class GeneratePath : MonoBehaviour
{
    // List of game object prefabs
    public GameObject[] gameObjectPrefabs;

    // Distance threshold for spawning new objects
    public float spawnDistanceThreshold = 30f;

    // Z-coordinate at which to spawn new objects
    private float spawnZ = 0f;

    // Reference to the player's transform
    private Transform playerTransform;

    // List to keep track of active game objects
    private List<GameObject> activeGameObjects = new List<GameObject>();

    void Start()
    {
        // Find the player's transform by tag
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        // Initial object spawning
        SpawnGameObject();
    }

    void Update()
    {
        // Check if the player has moved forward enough to spawn a new object
        if (playerTransform.position.z >= spawnZ - spawnDistanceThreshold)
        {
            SpawnGameObject();
        }
    }

    void SpawnGameObject()
    {
        // Select a random game object prefab
        GameObject randomGameObjectPrefab = gameObjectPrefabs[Random.Range(0, gameObjectPrefabs.Length)];

        // Instantiate the selected game object
        GameObject newGameObject = Instantiate(randomGameObjectPrefab, Vector3.forward * spawnZ, Quaternion.identity);

        // Add the new game object to the list of active game objects
        activeGameObjects.Add(newGameObject);

        // Update the spawn position for the next object
        spawnZ += spawnDistanceThreshold;
    }
}
