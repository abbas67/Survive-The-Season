using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {


    public InputField NameInpuField;
    public InputField NationalityInputField;



    int age;
    string nationality;
    string name;
    string team;
    bool employed;
    int stresslevel;
    int reputation;

    //constructor
    public Manager(int age, string nationality, string name, string team, bool emplyed, int stresslevel, int reputation)
        {

        age = 21;
        name = "Manager McManager";
        team = "team mcteamface";
        employed = false;
        stresslevel = 20;
        reputation = 25; 

        }



    public void ManagerCreate()
    {
        name = NameInpuField.text;

        nationality = NationalityInputField.text;
        
        Debug.Log("Welcome " + name + " from " + nationality);



    }



}
