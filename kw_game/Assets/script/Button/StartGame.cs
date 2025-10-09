using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public BHUI bhp;
    public ZTime timez;
    public void StartButton()
    {
        SceneManager.LoadScene("stage1");
        Score.coinAmount = 0;
        bhp.bosshp = 3;
        Scorebone.boneAmount = 0;
        bookScore.bookAmount = 0;
        ScoreSoju.sojuAmount = 0;
    }

    public void HomeButton()
    {
        // Ȩ ��ư�� ���� �� coinAmount�� 0���� ����
        
        SceneManager.LoadScene("start");
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}