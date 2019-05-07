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

    //Text objects to be used to display the matchday information

    public Text FinalScoreText;
    public Text ScorersText;
    public Text CardsText;
    public Text FoulsText;
    public Text GameDayText;

    public int GameWeek = 1;

    //creating an instance of the model class
    private Model MyModel = new Model();





    // When the kick off button is pressed the controller has the Model do the simulation behind the scenes.
    //The view then displays the results relevant to the user.
    public void displayKickOffInfo()
    {

        string[] KickInfo = new string[5];

        MyModel.Matchday();
        FinalScoreText = GameObject.Find("FinalScoreText").GetComponent<Text>();
        GameDayText = GameObject.Find("GameDayText").GetComponent<Text>();
        FoulsText = GameObject.Find("FoulsText").GetComponent<Text>();
        ScorersText = GameObject.Find("ScorersText").GetComponent<Text>();
        CardsText = GameObject.Find("CardsText").GetComponent<Text>();

        KickInfo = MyModel.DisplayResult();

        FinalScoreText.text = KickInfo[0];
  
        GameDayText.text = KickInfo[1];
    
        FoulsText.text = KickInfo[2];
        ScorersText.text = KickInfo[3];
        CardsText.text = KickInfo[4];
    


        GameWeek++;

    }


    //Every Time The matchday button is pressed
    //Controller then has Model prepare teams for matchday

    public void displayMatchPrep()
    {
        ScoutReportText = GameObject.Find("ScoutReportText").GetComponent<Text>();
        ScoutReportTitle = GameObject.Find("ScoutReportTitle").GetComponent<Text>();
        ScoutReportDetails = GameObject.Find("ScoutReportDetails").GetComponent<Text>();


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
        MyModel.SelectLM(buttonID);
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
        int[] AttackDefenceInfo = new int[2];

        AttackingThreatText = GameObject.Find("AttackingThreatText").GetComponent<Text>();
        DefensiveThreatText = GameObject.Find("DefensiveThreatText").GetComponent<Text>();
        TablePositionText = GameObject.Find("TablePositionText").GetComponent<Text>();

        CurrentGameplanText = GameObject.Find("CurrentGameplanText").GetComponent<Text>();
        GameplanCapabilityText = GameObject.Find("GameplanCapabilityText").GetComponent<Text>();

        TeamOverallText = GameObject.Find("TeamOverallText").GetComponent<Text>();

        TeamOverallText.text = ("Team Overall: " + MyModel.CalculateCurrOverall());

        Debug.Log(1);
        TablePositionText.text = MyModel.RetrievePos(TeamSetup.TeamManagedID);

        Debug.Log(2);
        AttackDefenceInfo = MyModel.CalculateCurrentThreat(TeamSetup.TeamManagedID);
        AttackingThreatText.text = ("Attacking Threat: " + AttackDefenceInfo[0] );
        DefensiveThreatText.text = ("Defensive Strength: " + AttackDefenceInfo[1]);



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
