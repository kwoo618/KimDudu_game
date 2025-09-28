using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI; // 서브메뉴 패널

    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false); // 서브메뉴 비활성화
        Time.timeScale = 1f; // 게임 시간 정상화
        isPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true); // 서브메뉴 활성화
        Time.timeScale = 0f; // 게임 시간 정지
        isPaused = true;
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit(); // 게임 종료
    }
}
