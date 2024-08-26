using UnityEngine;

public class FallDetector : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Check if the collider belongs to Doofus
        if (other.CompareTag("Doofus"))
        {
            Debug.Log("Game Over! Doofus fell.");
            // Here you can implement your game-over logic
            // For example, restart the game or show a game-over screen
            // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
