using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Sayac : MonoBehaviour
{
    public Image halka1;
    public TextMeshProUGUI count;
    public GameObject panel1;
    private float sayac= 60f;
    void Start()
    {
        count.text=sayac.ToString();
        StartCoroutine(zaman());
    }

   // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator zaman()
    {
        while(sayac>=0)
        { 
            halka1.fillAmount=Mathf.InverseLerp(0,60,sayac);
            count.text = sayac.ToString();

            yield return new WaitForSeconds(1f);
            sayac--;

        }
        yield return null;
        Time.timeScale = 0;
        panel1.SetActive(true);

        Destroy(gameObject);

    }
}
