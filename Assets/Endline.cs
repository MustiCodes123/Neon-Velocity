using UnityEngine;
using UnityEngine.SceneManagement;

public class Endline : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("HIT FUTURE");

            SceneManager.LoadScene("Future");
        }
    }
}
