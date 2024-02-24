using UnityEngine;
using UnityEngine.UI;

public class PotionPickup : MonoBehaviour
{
    public AudioSource sound;
    public Text potionCountText; // Reference to the UI text element displaying potion count
    private int potionCount = 0; // Variable to store the count of potions

    private void Start()
    {
        UpdatePotionCountUI(); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (sound != null)
            {
                Debug.Log("POTION COLLECTED");

                sound.Play();
                IncrementPotionCount(); 
                UpdatePotionCountUI();
                Destroy(gameObject); 
            }
        }
    }

    private void IncrementPotionCount()
    {
        potionCount++; 
    }

    private void UpdatePotionCountUI()
    {
        if (potionCountText != null)
        {
            potionCountText.text =  potionCount.ToString(); 
        }
    }

    public int GetPotionCount()
    {
        return potionCount; 
    }

}
