using UnityEngine;

public class DoofusSpawner : MonoBehaviour
{
    // Reference to the Doofus prefab
    public GameObject doofusPrefab;
    
    // Array of spawn points where Doofus will be instantiated
    public Transform[] spawnPoints;
    
    // Time interval between spawns
    public float spawnInterval = 5f;

    // Singleton instance
    public static DoofusSpawner Instance { get; private set; }

    private void Awake()
    {
        // Implement Singleton pattern to ensure only one instance exists
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Optional: keep spawner across scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // Start spawning Doofus at regular intervals
        InvokeRepeating("SpawnDoofus", 2f, spawnInterval);
    }

    private void SpawnDoofus()
    {
        // Debug log to verify that spawning is attempted
        Debug.Log("Attempting to spawn Doofus...");
        
        // Check if there are spawn points available
        if (spawnPoints.Length > 0)
        {
            // Choose a random spawn point from the array
            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];

            // Instantiate Doofus at the chosen spawn point
            Instantiate(doofusPrefab, spawnPoint.position, spawnPoint.rotation);
            Debug.Log("Doofus spawned at: " + spawnPoint.position);
        }
        else
        {
            Debug.LogWarning("No spawn points assigned!");
        }
    }
}
