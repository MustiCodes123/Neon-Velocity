using UnityEngine;

public class TimeCollector : MonoBehaviour
{
    public float timeAmount = 10f; // Amount of time to increase when collected
    public AudioSource sound; // Sound to play when collected
    public ReverseTimerController timecontroller;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("TIME COLLECTED");


            timecontroller.setTime(timecontroller.GetTimer()+10);


            Destroy(gameObject);

            sound.Play();

        }
    }
}
