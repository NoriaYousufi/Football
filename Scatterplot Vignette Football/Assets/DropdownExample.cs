using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 


public class DropdownExample : MonoBehaviour
{
    // DataPlotter dataPlotter;
    // [SerializeField] GameObject plotter; 

    // void Awake()
    // {
    //     dataPlotter = plotter.GetComponent<DataPlotter>();
    // }

    // List<string> columnNames = new List<string>(dataPlotter.pointList[1].Keys);
    //List<string> names = new List<string>() {"Fred", "Barney", "wilma", "Betty"};

    public Dropdown dropdown;
    public Text selectedAttribute;
    private DataPlotter dataPlotter;
    //DataPlotter dataPlotter;
    //List<string> columnList = new List<string>(DataPlotter.pointList[1].Keys);

    // public void Dropdown_IndexChanged(int index)
    // {
    //     selectedAttribute.text = columnList[index];
    // }

    void Start()
    {
        dataPlotter = GetComponent<DataPlotter>(); 
        List<string> columnList = new List<string>(DataPlotter.pointList[1].Keys);
        // dropdown.AddOptions(columnNames);
        // PopulateList();
        // dataPlotter = FindObjectOfType<DataPlotter>();
        // List<string> columnNames = new List<string>(dataPlotter.pointList[1].Keys);
    }

    // void PopulateList()
    // {
    //     // dataPlotter = GetComponent<DataPlotter>(); 
    //     // List<string> columnList = new List<string>(DataPlotter.pointList[1].Keys);
    //     dropdown.AddOptions(columnList);
    // }
}
