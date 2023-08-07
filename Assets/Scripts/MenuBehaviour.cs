using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBehaviour : MonoBehaviour
{
    public GameObject menu;
    public GameObject nextPanel;  
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void NextPanel()
    {
        menu.SetActive(false);
        nextPanel.SetActive(true);
    }
}
