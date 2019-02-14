using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerManagement : MonoBehaviour {

    public InputField NameInputBox;
    public InputField NationalityInputBox;
    public InputField AgeInputBox;

    int age;
    string nationality;
    string name;
    string team;
    bool employed;
    int stresslevel;
    int reputation;


    public ManagerManagement(int age, string nationality, string name, string team, bool emplyed, int stresslevel, int reputation)
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

    


    }



}
