using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Team : MonoBehaviour {

    public Text NameText;
    public Text ReputationText;
    public Text BudgetText;
    public Text AttackText;
    public Text DefenceText;
    public Text GroundText;

  


    string Name;
    int Reputation;
    int Budget;
    int Attack;
    int Defence;
    string Ground;
    int ManagementDiff;
    bool PlayerManaged;

    int index = 0;

    /*
    public Team(string Name ,int Reputation, int Budget, int Attack, int Defence, string Ground, int ManagementDiff, bool PlayerManaged)
    {

        Name = " ";
        Reputation = 25;
        Budget = 1000;
        Attack = 75;
        Defence = 75;
        Ground = "";
        ManagementDiff = 50;
        PlayerManaged = false;






    }
 



    */



    //"Dundee", 80, 800, 75, 70, "Balgay Park", 90, false






    Team DundeeRovers = new Team
    {
        Name = "Dundee Rovers",

    };











    public void TeamSelect()
    {

   
           
 








    }




    void Start()
    {
        NameText.text = " ";
        
        




    }
   










}
