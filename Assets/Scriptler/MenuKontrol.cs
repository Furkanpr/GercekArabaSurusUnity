using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuKontrol : MonoBehaviour
{
    public static bool gameIsPause;
    public GameObject pauseMenu;
    public GameObject seceneklerMenu;
    public GameObject Panel;
    public AudioSource theme;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (gameIsPause)
                Resume();
            else
                Pause();
        }
        // Klavyede "P" tuþuna basýldýðýnda pause fonksiyonu çalýþýp oyun durur. eðer oyun durmuþsa devam eder oyun.

    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Panel.SetActive(false);
        Time.timeScale = 1f;
        gameIsPause = false;
        //
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Panel.SetActive(true);
        Time.timeScale = 0f;
        gameIsPause = true;

    }
    public void LoadScene()
    {
        SceneManager.LoadScene(0);
    }
    public void ShowSecenekler()
    {
        pauseMenu.SetActive(false);
        seceneklerMenu.SetActive(true);
        gameIsPause = true;
    }
    public void SetQuality(int qual)
    {
        QualitySettings.SetQualityLevel(qual);
    }
    public void SetMusic(bool muzýk)
    {
        theme.mute = !muzýk;
    }
    public void evButon()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    } 
    public void YenileButon()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1f;

    }

}
