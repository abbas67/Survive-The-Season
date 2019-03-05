using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {


    public InputField NameInpuField;
    public InputField NationalityInputField;



    int ManAge;
    string ManNationality;
    string ManName;

    bool ManEmployed;
    int ManStress;
    int ManReputation;
    int ManTeamID;
    


    public void ManagerCreate()
    {
        NameInpuField = GameObject.Find("NameInpuField").GetComponent<InputField>();
        NationalityInputField = GameObject.Find("NationalityInputField").GetComponent<InputField>();



        name = NameInpuField.text;

        ManNationality = NationalityInputField.text;
        
        Debug.Log("Welcome " + ManName + " from " + ManNationality);



    }



}
