using UnityEngine;

public class EndGame : MonoBehaviour
{
    public Canvas gameOverCanvas; 

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameOverCanvas.enabled = true;

            Time.timeScale = 0f;
        }
    }
}
