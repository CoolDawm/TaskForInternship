using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegistrationMenuBehaviour : MonoBehaviour
{
    public GameObject menu;
    public GameObject registrationMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackToMainMenu()
    {
        menu.SetActive(true);
        registrationMenu.SetActive(false);
    }
}
