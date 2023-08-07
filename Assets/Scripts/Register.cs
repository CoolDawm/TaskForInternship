using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
public class Register : MonoBehaviour
{
    public GameObject Username;
    public GameObject Email;
    public GameObject Password;
    public GameObject ConfPassword;
    public Text ErrorText;
    private string username;
    private string password;
    private string email;
    private string confPassword;
    private string form;
    private string theEmailPattern = @"^[\w!#$%&'*+\-/=?\^_{|}~]+(\.[\w!#$%&'*+\-/=?\^_{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z";



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        username = Username.GetComponent<InputField>().text;
        email = Email.GetComponent<InputField>().text;
        password = Password.GetComponent<InputField>().text;
        confPassword = ConfPassword.GetComponent<InputField>().text;
    }
    public void RegisterOnClick()
    {
        if (DataValidation())
        {
            form = (username + "\n" + email + "\n" + password);
            System.IO.File.WriteAllText(@"C:\Users\lorik\Desktop\UnityTEstFolder\" + username + ".txt", form);
            Username.GetComponent<InputField>().text="";
            Email.GetComponent<InputField>().text = "";
            Password.GetComponent<InputField>().text = "";
            ConfPassword.GetComponent<InputField>().text = "";
            ErrorText.text = "Registered";
        }
        else {
            ErrorText.text = "There are some mistakes in your registration form";
        }
    }
    public bool DataValidation()
    {
        bool UN = false;
        bool EM = false;
        bool PW=false;
        bool CPW = false;
        if(password !=""&& email != "" && password != "" && confPassword != "")
        {
            
            if (!System.IO.File.Exists(@"C:\Users\lorik\Desktop\UnityTEstFolder\" + Username + ".txt"))
            {
                UN = true;
            }
            else
            {
                ErrorText.text="Username Taken";
            }
            
            if(Regex.IsMatch(email,theEmailPattern))
            {
                EM = true;
            }
            else
            {
                ErrorText.text = "Email is invalid";
            }
            if (password.Length > 8) {
                PW=true;
            }
            else
            {
                ErrorText.text = "Password is too short";
            }
            if (password==confPassword)
            {
                CPW = true;
            }
            else
            {
                ErrorText.text = "Password and Password confirmation dont match";
            }
            
        }
        else
        {
            ErrorText.text = "Some of the fields are empty";
        }
        if (PW == true && CPW == true && UN == true && EM == true)
        {
            return true;
        }
        else return false;
    }
}
