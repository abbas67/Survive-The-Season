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

    public bool ManEmployed;
    public int ManStress;
    public int ManReputation;
    public int ManTeamID;
    


    public void ManagerCreate()
    {

        name = NameInpuField.text;

        ManNationality = NationalityInputField.text;
        
        Debug.Log("Welcome " + ManName + " from " + ManNationality);



    }



}
