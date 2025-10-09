using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_S : MonoBehaviour
{
    public string sceneName;

    public void StartButton()
    {
        SceneManager.LoadScene("start");
    }
}
