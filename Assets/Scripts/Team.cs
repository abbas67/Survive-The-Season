using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Team : MonoBehaviour
{




    public string Name;
    public int Reputation;
    public int Budget;
    public int Attack;
    public int Defence;
    public string Ground;
    public int ManagementDiff;
    public bool PlayerManaged;

}






public class TeamBehaviour : MonoBehaviour
{
 






    public Text NameText;
    public Text ReputationText;
    public Text BudgetText;
    public Text AttackDefenceText;
    public Text DefenceText;
    public Text GroundText;
    Team DundeeRovers;
    Team LondonKings;
    Team LiverpoolRed;

    public void Start()
    {
        DundeeRovers = new Team();
        LondonKings = new Team();
        LiverpoolRed = new Team();



        NameText = GameObject.Find("NameText").GetComponent<Text>();
        ReputationText = GameObject.Find("ReputationText").GetComponent<Text>();
        BudgetText = GameObject.Find("BudgetText").GetComponent<Text>();
        AttackDefenceText = GameObject.Find("AttackDefenceText").GetComponent<Text>();
        GroundText = GameObject.Find("GroundText").GetComponent<Text>();
    }


    public void TeamSelect(int index)
    {
        

        DundeeRovers.Name = "Dundee Rovers";
        DundeeRovers.Reputation = 50;
        DundeeRovers.Budget = 1000;
        DundeeRovers.Attack = 75;
        DundeeRovers.Defence = 80;
        DundeeRovers.Ground = "Lochee Park";


        LondonKings.Name = "London Kings";
        LondonKings.Reputation = 99;
        LondonKings.Budget = 10000;
        LondonKings.Attack = 99;
        LondonKings.Defence = 99;
        LondonKings.Ground = "Stamford Park";

        LiverpoolRed.Name = "Liverpool Red";
        LiverpoolRed.Reputation = 80;
        LiverpoolRed.Budget = 15000;
        LiverpoolRed.Attack = 80;
        LiverpoolRed.Defence = 67;
        LiverpoolRed.Ground = "AnnPitch";


        if (index == 0)
            {
            
            NameText.text = ("Name: " + DundeeRovers.Name);
            ReputationText.text = ("Reputation: " + DundeeRovers.Reputation);
            BudgetText.text = ("Budget: " + DundeeRovers.Budget);
            AttackDefenceText.text = ("Attack/Defence: " + DundeeRovers.Attack + "/" + DundeeRovers.Defence);         
            GroundText.text = ("Ground: " + DundeeRovers.Ground);
           }

        if (index == 1)
        {

            NameText.text = ("Name: " + LondonKings.Name);
            ReputationText.text = ("Reputation: " + LondonKings.Reputation);
            BudgetText.text = ("Budget: " + LondonKings.Budget);
            AttackDefenceText.text = ("Attack/Defence: " + LondonKings.Attack + "/" + LondonKings.Defence);
            GroundText.text = ("Ground: " + LondonKings.Ground);
        }

        if (index == 2)
        {

            NameText.text = ("Name: " + LiverpoolRed.Name);
            ReputationText.text = ("Reputation: " + LiverpoolRed.Reputation);
            BudgetText.text = ("Budget: " + LiverpoolRed.Budget);
            AttackDefenceText.text = ("Attack/Defence: " + LiverpoolRed.Attack + "/" + LiverpoolRed.Defence);
            GroundText.text = ("Ground: " + LiverpoolRed.Ground);
        }

    }









}
