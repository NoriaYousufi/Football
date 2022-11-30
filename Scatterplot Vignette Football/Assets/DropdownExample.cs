using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 


public class DropdownExample : MonoBehaviour
{
    DataPlotter dataPlotter;
    [SerializeField] GameObject plotter; 

    void Awake()
    {
        dataPlotter = plotter.GetComponent<DataPlotter>();
    }

    //List<string> columnNames = new List<string>(dataPlotter.pointList[1].Keys);
    List<string> names = new List<string>() {"Fred", "Barney", "wilma", "Betty"};

    public Dropdown dropdown;
    public Text selectedAttribute;

    public void Dropdown_IndexChanged(int index)
    {
        selectedAttribute.text = names[index];
    }

    void Start()
    {
        PopulateList();
    }

    void PopulateList()
    {
        dropdown.AddOptions(names);
    }
}
