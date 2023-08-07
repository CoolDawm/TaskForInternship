using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
public class Login : MonoBehaviour
{
    public GameObject menu;
    public GameObject applicationMenu;
    public GameObject Username;
    public GameObject Password;
    public GameObject appUsername;
    public GameObject appPassword;
    public Text ErrorText;
    private string password;
    private string username;
    private string[] lines;
    void Start()
    {
        
    }
    public void LoginOnClick()
    {
        if (DataValidation())
        {
            Username.GetComponent<InputField>().text="";
            Password.GetComponent<InputField>().text="";   
            appUsername.GetComponent<InputField>().text=username;
            appPassword.GetComponent<InputField>().text=password;
            menu.SetActive(false);
            applicationMenu.SetActive(true);
            ErrorText.text = "";
        }
    }
    public bool DataValidation()
    {
        if (username!="" && password!="")
        {
            if(System.IO.File.Exists(@"C:\Users\lorik\Desktop\UnityTEstFolder\" + username + ".txt"))
            {
                lines = System.IO.File.ReadAllLines(@"C:\Users\lorik\Desktop\UnityTEstFolder\" + username + ".txt");
                if (password == lines[2]) {
                    return true;
                }
                else
                {
                    ErrorText.text = "Invalid password or username";
                    return false;
                }
            }
            else
            {
                ErrorText.text = "There  is no users with name like that";
                return false;
            }         
        }
        else
        {
            ErrorText.text = "There are some empty input fields";
            return false;
        }
    }
    void Update()
    {
        username = Username.GetComponent<InputField>().text;
        password = Password.GetComponent<InputField>().text;
    }
}
