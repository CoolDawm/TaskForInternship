using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBehaviour : MonoBehaviour
{
    public GameObject menu;
    public GameObject registrationMenu;  
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void Registration()
    {
        menu.SetActive(false);
        registrationMenu.SetActive(true);
    }
}
