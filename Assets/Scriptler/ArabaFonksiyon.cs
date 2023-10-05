    using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArabaFonksiyon : MonoBehaviour
{
    public WheelCollider önsoltekerlek, önsaðtekerlek, arkasoltekerlek, arkasaðtekerlek;
    public float motorhýzý, dönmehýzý;
    public Joystick tus;
    int puan = 0;
    int koleksiyon = 0;
    public TextMeshProUGUI puanGoster;
    public TextMeshProUGUI KoleksiyonGöster;
    public TextMeshProUGUI SaniyeGöster;
    public GameObject koleksiyonUI;
    public GameObject YarýsPanel;

   
    
    void Update()
    {


        arkasaðtekerlek.motorTorque = motorhýzý * Input.GetAxis("Vertical"); 
        // Aracýn ileri geri gitmesini saðlar, dikey hareket yapar
        arkasoltekerlek.motorTorque = motorhýzý * Input.GetAxis("Vertical");
        // Aracýn ileri geri gitmesini saðlar, dikey hareket yapar
        önsaðtekerlek.steerAngle = dönmehýzý * Input.GetAxis("Horizontal");
        // Aracýn dönüþünü saðlar , yatay haraket yapar
        önsoltekerlek.steerAngle = dönmehýzý * Input.GetAxis("Horizontal");
        // Aracýn dönüþünü saðlar , yatay haraket yapar

        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Altýn")
        {
            puan++;
            Destroy(other.gameObject);
            puanGoster.text = "Puan " + puan;
        }
        if (other.gameObject.tag == "Koleksiyon")
        {
            koleksiyonUI.SetActive(true);
            koleksiyon++;
            Destroy(other.gameObject);

            KoleksiyonGöster.text = koleksiyon + " / 3 KOLEKSÝYON TOPLANDI ";
            StartCoroutine(ucsaniyebekle());
            }
            if(other.gameObject.tag == "YarýsAlaný")
            {
                Time.timeScale = 0;
                YarýsPanel.SetActive(true);
            }


     
     




    }
    public void YarýsAlanýX()
    {
        //  StartCoroutine(ucsaniyebekle());
        YarýsPanel.SetActive(false);

        Time.timeScale = 1;
    } 
    public void YarýsAlanýtik()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(3);
    }

    IEnumerator ucsaniyebekle()
    {
        yield return new WaitForSecondsRealtime(3f);
        koleksiyonUI.SetActive(false);



    }
}