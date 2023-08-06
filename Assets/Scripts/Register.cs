using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
public class Register : MonoBehaviour
{
    public GameObject username;
    public GameObject email;
    public GameObject password;
    public GameObject confPassword;
    private string Username;
    private string Password;
    private string Email;
    private string ConfPassword;
    private string form;
    private bool emailVAlid=false;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Username = username.GetComponent<InputField>().text;
        Email = email.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
        ConfPassword = confPassword.GetComponent<InputField>().text;
    }
    public void RegisterOnClick()
    {
        if(Password!=""&& Email != "" && Password != "" && ConfPassword != "")
        {
            Debug.Log("Registration Successful");
        }
    }
}
