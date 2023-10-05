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

    public InputField dýsusername;
    public InputField dýsemail;
    public InputField dýspassword;


     string username;
     string email;
     string password;


   public void Deneme()
    {

            username = dýsusername.GetComponent<InputField>().text;
            password = dýspassword.GetComponent<InputField>().text;
            email = dýsemail.GetComponent<InputField>().text;

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