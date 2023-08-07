using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
public class DataChange : MonoBehaviour
{
    public GameObject Username;
    public GameObject Password;
    private string oldPassword;
    private string oldUsername;
    private string password;
    private string username;
    private string[] lines;
    private string form;
    // Start is called before the first frame update
    void Start()
    {
        username = Username.GetComponent<InputField>().text;
        password = Password.GetComponent<InputField>().text;
    }
    public void ChangeDataOnClick()
    {
        lines = System.IO.File.ReadAllLines(@"C:\Users\lorik\Desktop\UnityTEstFolder\" + oldUsername + ".txt");
        System.IO.File.Delete(@"C:\Users\lorik\Desktop\UnityTEstFolder\" + oldUsername + ".txt");
        lines[0] = Username.GetComponent<InputField>().text;
        lines[2] = Password.GetComponent<InputField>().text;
        form = (lines[0] + "\n" + lines[1] + "\n" + lines[2]);
        System.IO.File.WriteAllText(@"C:\Users\lorik\Desktop\UnityTEstFolder\" + lines[0] + ".txt", form);
    }
    public void InputFieldsUnlock()
    {
        oldUsername = Username.GetComponent<InputField>().text;
        oldPassword = Password.GetComponent<InputField>().text;
        Username.GetComponent<InputField>().interactable = true;
        Password.GetComponent<InputField>().interactable = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
