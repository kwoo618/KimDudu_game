using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    public string sceneName;

    // Start is called before the first frame update
    void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
        ZTime2.Instance.ResetTimer(); // 타이머 초기화
        Score.coinAmount = 0;
        Scorebone.boneAmount = 0;
    }
}