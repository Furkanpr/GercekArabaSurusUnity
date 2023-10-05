using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class arabaDegis : MonoBehaviour
{
    public GameObject[] arabalar;
    public int a = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
   public void ileriAraba()
    {
        arabalar[a].SetActive(false);
        a++;
        if(a== arabalar.Length)
            a= 0;
       // a= a % arabalar.Length;
        arabalar[a].SetActive(true);

    }
    public void geriAraba()
    {
        arabalar[a].SetActive(false);
        a--;
        if (a < 0)
        {
            a = arabalar.Length - 1;    
        }
        arabalar[a].SetActive(true);

    }
    public void UI()
    {
        SceneManager.LoadScene(0);
    }
}
/*
public void ileri()
{
    arabalar[a].SetActive = false;
    a++;
   if( a==arabalar.length)
        a= 0;
   ara
}*/