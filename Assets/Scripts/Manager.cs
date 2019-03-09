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

   
    static public int ManStress = 50;
    static public int ManReputation = 50;



    public void Start()
    {

        NameInpuField = GameObject.Find("NameInputField").GetComponent<InputField>();
        NationalityInputField = GameObject.Find("NationalityInputField").GetComponent<InputField>();



    }


    public void ManagerCreate()
    {




        name = NameInpuField.text;

        ManNationality = NationalityInputField.text;
        
        Debug.Log("Welcome " + ManName + " from " + ManNationality);



    }



}
