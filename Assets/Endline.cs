using UnityEngine;
using UnityEngine.SceneManagement;

public class Endline : MonoBehaviour
{
    private void OnCollisionEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Future");
        }
    }
}
