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

    // DataPlotter dataPlotter;

    // void Awake()
    // {
    //     dataPlotter = GameObject.Find("Plotter").GetComponent<DataPlotter>();
    // }

    // List<string> columnNames = new List<string>(dataPlotter.pointList[1].Keys);
    //"Rk", "Age", "Born", "MP", "Starts", "Min", "90s", "Goals", "Shots"
    List<string> names = new List<string>() {"Rk", "Age", "Born", "MP", "Starts", "Min", "90s", "Goals", "Shots", "SoT", "SoT%", "G/Sh", "G/SoT", "ShoDist", "ShoFK", "ShoPK", "PKatt", "PasTotCmp", "PasTotAtt", "PasTotCmp%", "PasTotDist", "PasTotPrgDist", "PasShoCmp", "PasShoAtt", "PasShoCmp%", "PasMedCmp", "PasMedAtt", "PasMedCmp%"};

    public Dropdown dropdown;
    public Text selectedAttribute;
    public int dropdownValue; 
    //private DataPlotter dataPlotter;
    //DataPlotter dataPlotter;
    //List<string> columnList = new List<string>(DataPlotter.pointList[1].Keys);

    public void Dropdown_IndexChanged(int index)
    {
        selectedAttribute.text = names[index];
    }

    void Start()
    {
        // dataPlotter = GetComponent<DataPlotter>(); 
        // List<string> columnList = new List<string>(DataPlotter.pointList[1].Keys);
        // dropdown.AddOptions(columnNames);
        PopulateList();
        Debug.Log("Dropdown value: " + dropdown.value);
        // dataPlotter = FindObjectOfType<DataPlotter>();
        // List<string> columnNames = new List<string>(dataPlotter.pointList[1].Keys);
    }

    void PopulateList()
    {
        // dataPlotter = GetComponent<DataPlotter>(); 
        // List<string> columnList = new List<string>(DataPlotter.pointList[1].Keys);
        //List<string> names = new List<string>() {"Fred", "Barney", "Wilma", "Betty"};
        dropdown.AddOptions(names);
    }

    void Update()
    {
        dropdownValue = dropdown.value; 
        Debug.Log("Current dropdown value: "+ dropdown.value);
    }
}
