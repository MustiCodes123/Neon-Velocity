using UnityEngine;
using UnityEngine.UI;

public class TimeCollector : MonoBehaviour
{
    public float timeAmount = 10f; // Amount of time to increase when collected
    public AudioSource sound; // Sound to play when collected
    public Text timeText; // Reference to the UI text element displaying time

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            Debug.Log("TIME COLLECTED");

            sound.Play();

            // Parse the current time from the UI text
            float currentTime = float.Parse(timeText.text);

            // Add the timeAmount to the current time
            currentTime += timeAmount;

            // Update the UI text with the new time
            timeText.text = currentTime.ToString();

            // Destroy the time collector GameObject
            Destroy(gameObject);
        }
    }
}
