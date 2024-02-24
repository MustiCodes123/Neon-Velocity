using UnityEngine;
using UnityEngine.UI;

public class ReverseTimerController : MonoBehaviour
{
    public static ReverseTimerController instance;
    public Text timerText; // Reference to the Text component of the UI Text element
    [SerializeField] private float timer = 0f;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UpdateTimerUI();
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if (timer >= 0)
                UpdateTimerUI();
        }
    }

    void UpdateTimerUI()
    {
        int seconds = Mathf.FloorToInt(timer % 60);

        timerText.text = seconds.ToString();
    }

    public float GetTimer()
    {
        return timer;
    }

    public void setTime(float time)
    {
        timer += time;
    }
}
