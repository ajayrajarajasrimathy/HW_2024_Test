using UnityEngine;

public class PulpitManager : MonoBehaviour
{
    public GameObject pulpitPrefab; // Reference to the Pulpit prefab
    public float pulpitLifetime = 3f; // How long each pulpit lasts
    public Transform[] spawnPoints; // Array to hold spawn points

    void Start()
    {
        // Spawn a pulpit at random intervals
        InvokeRepeating("SpawnPulpit", 1f, 2f); // Adjust timing as needed
    }

    void SpawnPulpit()
    {
        // Choose a random spawn point from the array
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[spawnIndex];

        // Instantiate the pulpit at the chosen spawn point's position
        GameObject pulpit = Instantiate(pulpitPrefab, spawnPoint.position, spawnPoint.rotation);
        Destroy(pulpit, pulpitLifetime); // Destroy pulpit after its lifetime
    }
}
