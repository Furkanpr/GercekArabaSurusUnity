 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;
 using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using TMPro;

public class userInsert : MonoBehaviour
{

    string URL = "http://localhost/mydb/userInsert.php";

    public InputField d�susername;
    public InputField d�semail;
    public InputField d�spassword;


     string username;
     string email;
     string password;


   public void Deneme()
    {

            username = d�susername.GetComponent<InputField>().text;
            password = d�spassword.GetComponent<InputField>().text;
            email = d�semail.GetComponent<InputField>().text;

        WWWForm form = new WWWForm();
        form.AddField("addUsername", username);
        form.AddField("addEmail", email);
        form.AddField("addPassword", password);
        WWW www = new WWW(URL, form);

        
    }
    

}
/*
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class userInsert : MonoBehaviour
{
    string URL = "http://localhost/mydb/userInsert.php";
    public string InputUsername, InputEmail, InputPassword;
    void Start()
    {

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddUser(InputUsername, InputEmail, InputPassword);
        }
    }
    public void AddUser(string username, string email, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("addUsername", username);
        form.AddField("addEmail", email);
        form.AddField("addPassword", password);
        WWW www = new WWW(URL, form);
    }
}

*/