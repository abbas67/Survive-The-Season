using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class ViewController : MonoBehaviour
{
    //Text objects to be used to display the scout report and tactics information
    public Text ScoutReportText;
    public Text ScoutReportTitle;
    public Text ScoutReportDetails;
    public Text TeamOverallText;
    public Text TablePositionText;
    public Text AttackingThreatText;
    public Text DefensiveThreatText;
    public Text CurrentGameplanText;
    public Text GameplanCapabilityText;
    public Button PressureBtn;
    public Button CounterBtn;
    public Button PossesionBtn;


    public int GameWeek = 1;

    //creating an instance of the model class
    private Model MyModel = new Model();





    //Every Time The matchday button is pressed
    //Controller then has Model prepare teams for matchday

    public void displayMatchPrep()
    {
        ScoutReportText = GameObject.Find("ScoutReportText").GetComponent<Text>();
        ScoutReportTitle = GameObject.Find("ScoutReportTitle").GetComponent<Text>();
        ScoutReportDetails = GameObject.Find("ScoutReportDetails").GetComponent<Text>();
        TablePositionText = GameObject.Find("TablePositionText").GetComponent<Text>();


        if (GameWeek > 22)
        {

            Debug.Log("Season Over");
        }
        else
        {
            //Displaying the Scout Report for the player.
            string[] ScoutReportInfo = new string[3];

            ScoutReportInfo = MyModel.prepareTeams(GameWeek);
            ScoutReportTitle.text = ScoutReportInfo[0];
            ScoutReportText.text = ScoutReportInfo[1];
            ScoutReportDetails.text = ScoutReportInfo[2];


        }


    }




    //Every time the team selection Button is pressed.
    //Controller has retrieves team info from model and gives to view.
    public void displayTeamSelection()
    {


        MyModel.displayOptions();



    }
    //Handling the user input for selecting the starting 11 and selecting tactics.
    // View recieves user input, Controller then takes this input and has Model make a change.
    public void selectMF(int buttonID)
    {
        MyModel.SelectMF(buttonID);
    }
    public void selectST(int buttonID)
    {
        MyModel.SelectST(buttonID);
    }
    public void selectRM(int buttonID)
    {
        MyModel.SelectRM(buttonID);
    }
    public void selectLM(int buttonID)
    {
        MyModel.SelectRM(buttonID);
    }
    public void selectGK(int buttonID)
    {
        MyModel.SelectGK(buttonID);
    }
    public void selectLB(int buttonID)
    {
        MyModel.SelectLB(buttonID);
    }
    public void selectRB(int buttonID)
    {
        MyModel.SelectRB(buttonID);
    }
    public void selectCB(int buttonID)
    {
        MyModel.SelectCB(buttonID);
    }



    // Model completes calculations which are then displayed to the user by view.
    public void RetrieveTeamInfo()
    {

        CurrentGameplanText = GameObject.Find("CurrentGameplanText").GetComponent<Text>();
        GameplanCapabilityText = GameObject.Find("GameplanCapabilityText").GetComponent<Text>();

        TeamOverallText = GameObject.Find("TeamOverallText").GetComponent<Text>();

        TeamOverallText.text = ("Team Overall: " + MyModel.CalculateCurrOverall());

        MyModel.RetrievePos(TeamSetup.TeamManagedID);





    }

    public void DisplayPossesionPlan()
    {
        PossesionBtn = GameObject.Find("PossesionBtn").GetComponent<Button>();
        GameplanCapabilityText.text = ("Gameplan Capability: " + MyModel.returnPossessionPlan(MyModel.SelectedSquad, TeamSetup.TeamManagedID));
        CurrentGameplanText.text = ("Possesion");

    }

    public void ViewCounterPlan()
    {

        CounterBtn = GameObject.Find("CounterBtn").GetComponent<Button>();
        GameplanCapabilityText.text = ("Gameplan Capability: " + MyModel.returnCounterPlan(MyModel.SelectedSquad, TeamSetup.TeamManagedID));
        CurrentGameplanText.text = ("Counter");

    }

    public void ViewPressurePlan()
    {
        PressureBtn = GameObject.Find("PressureBtn").GetComponent<Button>();
        GameplanCapabilityText.text = ("Gameplan Capability: " + MyModel.returnPressurePlan(MyModel.SelectedSquad ,TeamSetup.TeamManagedID));
        CurrentGameplanText.text = ("Pressure");

    }



    // Start is called before the first frame update
    void Start()
    {
        //Teams for matchday are prepared

        MyModel.InitModel();
    }

}
