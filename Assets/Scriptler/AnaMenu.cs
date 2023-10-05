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
    public GameObject PanelKayýtOl;
    public GameObject PanelCýkýsYap;
    public GameObject PanelÞifreKabul;


    [Header("UI")]

    public GameObject pauseMenu;
    public GameObject seceneklerMenu;
    public AudioSource them;
    [Header("VeriTabaný")]
    public InputField dýsusername;
    public InputField dýsemail;
    public InputField dýspassword;
    public InputField dýspassword1;


    public void Database()
    {

        username = dýsusername.GetComponent<InputField>().text;
        password = dýspassword.GetComponent<InputField>().text;
        password1 = dýspassword1.GetComponent<InputField>().text;
        email = dýsemail.GetComponent<InputField>().text;
        
            if (password != password1)
            {

                PanelÞifreKabul.SetActive(true);
                Panel.SetActive(false);
                PanelKayýtOl.SetActive(true);
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
                PanelKayýtOl.SetActive(false);
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
    public void kayýtOl()
    {
        PanelKayýtOl.SetActive(true);
        Panel.SetActive(false);
        pauseMenu.SetActive(false);
        seceneklerMenu.SetActive(false);
    }
    public void SetQuality(int qual)
    {
        QualitySettings.SetQualityLevel(qual);
    }
    public void SetMusic(bool muzýk)
    {
        them.mute = !muzýk;
    }
    public void quitGame()
    {
        Application.Quit();
        Debug.Log("test");
    }
   
    
    public void cýkýsYapma()
    {
        PanelCýkýsYap.SetActive(true);
        PanelKayýtOl.SetActive(false);
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
