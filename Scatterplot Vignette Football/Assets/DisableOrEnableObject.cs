using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class DisableOrEnableObject : MonoBehaviour
{
    // public GameObject Plotter; 
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    // public void whenButtonClicked()
    // {
    //     if (Plotter.activeInHierarchy == true)
    //         Plotter.SetActive(false);
    //     else
    //         Pquare.SetActive(true);
    // }

    public GameObject Plotter;
    
    public void ButtonPressed() 
    {
        if (Plotter.activeInHierarchy == true)
            Plotter.SetActive(false);
        else
            Plotter.SetActive(true);
    }

}
