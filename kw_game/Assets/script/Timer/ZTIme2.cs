using UnityEngine;

public class ZTime2 : MonoBehaviour
{
    public static ZTime2 Instance { get; private set; }
    public float time = 600;
    public bool isTimerRunning = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (isTimerRunning && time > 0)
        {
            time -= Time.deltaTime;
        }
    }

    public void StartTimer()
    {
        isTimerRunning = true;
    }

    public void StopTimer()
    {
        isTimerRunning = false;
    }

    public void ResetTimer()
    {
        time = 600;
        isTimerRunning = false;
    }
}