using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ZTime : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    public string sceneName;

    private void Start()
    {
        ZTime2.Instance.StartTimer();
        StartCoroutine(UpdateTimer());
    }

    IEnumerator UpdateTimer()
    {
        while (ZTime2.Instance.time > 0)
        {
            int minute = (int)ZTime2.Instance.time / 60;
            int second = (int)ZTime2.Instance.time % 60;
            text.text = minute.ToString("00") + ":" + second.ToString("00");
            yield return null;
        }

        SceneManager.LoadScene(sceneName);
    }
}