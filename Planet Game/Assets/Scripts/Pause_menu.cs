using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_menu : MonoBehaviour
{
    public void Resume(){
        Time.timeScale = 1f;
    }
    public void Pause(){
        //pause_ui.SetActive(true);
        Time.timeScale = 0f;
    }
    // Also restart after Game Over
    public void Reload(){
        Resume();
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name, LoadSceneMode.Single);

    }
    public void Quit(){
        Resume();
        SceneManager.LoadSceneAsync("Main Menu", LoadSceneMode.Single);
    }
    public void GoToNextStage()
    {
        SceneManager.LoadSceneAsync(GameManager.Instance.nextStage, LoadSceneMode.Single);
        Resume();
    }

    public void RestartNormal()
    {
        StopCoroutine(GameManager.Instance.grayscaleCoroutine);
        GameManager.Instance.player.GetComponent<SpriteRenderer>().material = GameManager.Instance.defaultMat;
        GameManager.playerDeaths = GameManager.PlayerDeaths.Alive;
        GameManager.Instance.set_health(3);
        GameManager.Instance.player.GetComponent<Gravity>().gravity = true;
        GameManager.Instance.playerInput.SwitchCurrentActionMap("PlayerControls");
        GameManager.Instance.gameControls.SetActive(true);
        GameManager.Instance.deadObj.SetActive(false);

        BorderDetector.borders = new List<GameObject>();

        GameManager.Instance.player.GetComponent<PlayerController>().resetPlayer();
    }
    public void GoToNextStageBread()
    {
        SceneManager.LoadSceneAsync(Game_Manager.Instance.nextStage, LoadSceneMode.Single);
        Resume();
    }
}
