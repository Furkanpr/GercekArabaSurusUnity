    using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArabaFonksiyon : MonoBehaviour
{
    public WheelCollider �nsoltekerlek, �nsa�tekerlek, arkasoltekerlek, arkasa�tekerlek;
    public float motorh�z�, d�nmeh�z�;
    public Joystick tus;
    int puan = 0;
    int koleksiyon = 0;
    public TextMeshProUGUI puanGoster;
    public TextMeshProUGUI KoleksiyonG�ster;
    public TextMeshProUGUI SaniyeG�ster;
    public GameObject koleksiyonUI;
    public GameObject Yar�sPanel;

   
    
    void Update()
    {


        arkasa�tekerlek.motorTorque = motorh�z� * Input.GetAxis("Vertical"); 
        // Arac�n ileri geri gitmesini sa�lar, dikey hareket yapar
        arkasoltekerlek.motorTorque = motorh�z� * Input.GetAxis("Vertical");
        // Arac�n ileri geri gitmesini sa�lar, dikey hareket yapar
        �nsa�tekerlek.steerAngle = d�nmeh�z� * Input.GetAxis("Horizontal");
        // Arac�n d�n���n� sa�lar , yatay haraket yapar
        �nsoltekerlek.steerAngle = d�nmeh�z� * Input.GetAxis("Horizontal");
        // Arac�n d�n���n� sa�lar , yatay haraket yapar

        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Alt�n")
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

            KoleksiyonG�ster.text = koleksiyon + " / 3 KOLEKS�YON TOPLANDI ";
            StartCoroutine(ucsaniyebekle());
            }
            if(other.gameObject.tag == "Yar�sAlan�")
            {
                Time.timeScale = 0;
                Yar�sPanel.SetActive(true);
            }


     
     




    }
    public void Yar�sAlan�X()
    {
        //  StartCoroutine(ucsaniyebekle());
        Yar�sPanel.SetActive(false);

        Time.timeScale = 1;
    } 
    public void Yar�sAlan�tik()
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