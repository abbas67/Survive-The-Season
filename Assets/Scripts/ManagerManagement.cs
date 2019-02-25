using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {


    public InputField NameInpuField;
    public InputField NationalityInputField;



    public int ManAge;
    public string ManNationality;
    public string ManName;
    public string ManTeam;
    public bool ManEmployed;
    public int ManStress;
    public int ManReputation;

    //constructor
    public Manager(int age, string nationality, string name, string team, bool emplyed, int stresslevel, int reputation)
        {

        ManAge = 21;
        ManName = "Manager McManager";
        ManTeam = "team mcteamface";
        ManEmployed = false;
        ManStress = 20;
        ManReputation = 25; 

        }



    public void ManagerCreate()
    {

        name = NameInpuField.text;

        ManNationality = NationalityInputField.text;
        
        Debug.Log("Welcome " + ManName + " from " + ManNationality);



    }



}
