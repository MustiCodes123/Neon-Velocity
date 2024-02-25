using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToRetro : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            SceneManager.LoadScene("Retro");
        }
    }
}
