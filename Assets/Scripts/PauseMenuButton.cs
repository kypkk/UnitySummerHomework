using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuButton : MonoBehaviour
{
  public GameObject PauseMenuUI;
  PauseMenu pauseMenu;
  private void Start()
  {
    pauseMenu = GameObject.FindGameObjectWithTag("PauseMenu").GetComponent<PauseMenu>();
  }
  public void resumeGame()
  {
    pauseMenu.gameIsPaused = false;
    PauseMenuUI.SetActive(false);
    Time.timeScale = 1f;
  }
  public void GotoMenu()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
  }
  public void QuitGame()
  {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #else
        Application.Quit();
    #endif
  }
}
