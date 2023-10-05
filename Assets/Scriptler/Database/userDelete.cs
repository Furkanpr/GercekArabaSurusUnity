using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class userDelete : MonoBehaviour
{
    string URL = "http://localhost/mydb/userDelete.php";
    public string  whereField, whereCondition;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            DeleteUser(whereField, whereCondition);
        }

    }
    public void DeleteUser( string wF, string wC)
    {
        WWWForm form = new WWWForm();

        form.AddField("whereField", wF);
        form.AddField("whereCondition", wC);
        WWW www = new WWW(URL, form);
    }
}
