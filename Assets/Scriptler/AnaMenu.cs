using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;
using System;

public class AnaMenu : MonoBehaviour
{
    string URL = "http://localhost/mydb/userInsert.php";

    string username;
    string email;
    string password;
    string password1;

    [Header("Panel")]
    public GameObject Panel;
    public GameObject PanelKay�tOl;
    public GameObject PanelC�k�sYap;
    public GameObject Panel�ifreKabul;


    [Header("UI")]

    public GameObject pauseMenu;
    public GameObject seceneklerMenu;
    public AudioSource them;
    [Header("VeriTaban�")]
    public InputField d�susername;
    public InputField d�semail;
    public InputField d�spassword;
    public InputField d�spassword1;


    public void Database()
    {

        username = d�susername.GetComponent<InputField>().text;
        password = d�spassword.GetComponent<InputField>().text;
        password1 = d�spassword1.GetComponent<InputField>().text;
        email = d�semail.GetComponent<InputField>().text;
        
            if (password != password1)
            {

                Panel�ifreKabul.SetActive(true);
                Panel.SetActive(false);
                PanelKay�tOl.SetActive(true);
                pauseMenu.SetActive(false);
                seceneklerMenu.SetActive(false);
            }
            else
            {
                WWWForm form = new WWWForm();
                form.AddField("addUsername", username);
                form.AddField("addEmail", email);
                form.AddField("addPassword", password);
                WWW www = new WWW(URL, form);
                Panel.SetActive(true);
                PanelKay�tOl.SetActive(false);
                seceneklerMenu.SetActive(false);

                StartCoroutine(ikisaniyebekle());





        }

    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1.0f;
    }
    public void Ayarlar()
    {
        Panel.SetActive(true);
        pauseMenu.SetActive(true);



    }
    public void showSeceneklerMenu()
    {
        Panel.SetActive(true);
        pauseMenu.SetActive(false);
        seceneklerMenu.SetActive(true);
    }
    public void kay�tOl()
    {
        PanelKay�tOl.SetActive(true);
        Panel.SetActive(false);
        pauseMenu.SetActive(false);
        seceneklerMenu.SetActive(false);
    }
    public void SetQuality(int qual)
    {
        QualitySettings.SetQualityLevel(qual);
    }
    public void SetMusic(bool muz�k)
    {
        them.mute = !muz�k;
    }
    public void quitGame()
    {
        Application.Quit();
        Debug.Log("test");
    }
   
    
    public void c�k�sYapma()
    {
        PanelC�k�sYap.SetActive(true);
        PanelKay�tOl.SetActive(false);
        Panel.SetActive(true);
        pauseMenu.SetActive(false);
        seceneklerMenu.SetActive(false);

    }
    IEnumerator ikisaniyebekle()
    {
        yield return new WaitForSecondsRealtime(1f);
        pauseMenu.SetActive(true);


        
    }
    public void Garage()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1.0f;

    }


}
