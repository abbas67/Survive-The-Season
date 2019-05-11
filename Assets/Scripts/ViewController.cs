using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class ViewController : MonoBehaviour
{


    public Text NotificationsText;
    public Text ManagerText;

    public InputField NameInpuField;
    public InputField NationalityInputField;

    public Button RaiseButton;


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



    public Text GameWeekTxt;
    public Text ManStressTxt;
    public Text ManNameTxt;
    //Text objects to be used to display the matchday information

    public Text FinalScoreText;
    public Text ScorersText;
    public Text CardsText;
    public Text FoulsText;
    public Text GameDayText;

    public int GameWeek = 1;

    //creating an instance of the model class
    private Model MyModel = new Model();


    Text NameText;
    public Text ReputationText;
    public Text BudgetText;
    public Text AttackDefenceText;
    public Text GroundText;



    public Text BoardText;
    public Text FanText;

    string[] Notificationinfo = new string[4];

    // When the kick off button is pressed the controller has the Model do the simulation behind the scenes.
    //The view then displays the results relevant to the user.
    public void displayKickOffInfo()
    {

        string[] KickInfo = new string[5];

        MyModel.Matchday(GameWeek);
        FinalScoreText = GameObject.Find("FinalScoreText").GetComponent<Text>();
        GameDayText = GameObject.Find("GameDayText").GetComponent<Text>();
        FoulsText = GameObject.Find("FoulsText").GetComponent<Text>();
        ScorersText = GameObject.Find("ScorersText").GetComponent<Text>();
        CardsText = GameObject.Find("CardsText").GetComponent<Text>();

        KickInfo = MyModel.DisplayResult(GameWeek);

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

    public void populateTable()
    {

        MyModel.PointsUpdater();
        MyModel.PopulateTable();



    }



    public void RequestRaise()
    {
        RaiseButton = GameObject.Find("RaiseButton").GetComponent<Button>();


        bool BoardResponse = MyModel.tryRaise();

        if (BoardResponse == false)
        {

            ManagerText.text = Notificationinfo[1] + "\n  \n " + Notificationinfo[2] + "\n  \n " + "Your request for a raise was denied and you are frustrated, Stress + 1 ";


        }
        if (BoardResponse == true)
        {

            ManagerText.text = Notificationinfo[1] + "\n  \n " + Notificationinfo[2] + "\n  \n " + "Your request for a raise was accepted , Stress - 10 ";


        }

        DisplayPlayerInfo();

        RaiseButton.GetComponent<Image>().color = Color.grey;
        RaiseButton.GetComponentInChildren<Text>().text = "You can only request a raise once per game";
        RaiseButton.GetComponent<Button>().interactable = false;

    }

    public void DisplayManagerInfo()
    {
        ManagerText = GameObject.Find("ManagerText").GetComponent<Text>();

        ManagerText.text = Notificationinfo[1] + "\n  \n " + Notificationinfo[2];


    }

    public void DisplayNotificaitons()
    {
        NotificationsText = GameObject.Find("NotificationsTxt").GetComponent<Text>();




        Notificationinfo = MyModel.GetNotifications();



        NotificationsText.text = Notificationinfo[0];

    }


    public void populateSquad()
    {


        MyModel.populateSquad();


    }


    public void nextSquadPage()
    {

        MyModel.NextSquadPage();

    }

    public void backSquadPage()
    {

        MyModel.BackSquadPage();

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


        TablePositionText.text = MyModel.RetrievePos(MyModel.TeamManagedID);


        AttackDefenceInfo = MyModel.CalculateCurrentThreat(MyModel.TeamManagedID);
        AttackingThreatText.text = ("Attacking Threat: " + AttackDefenceInfo[0]);
        DefensiveThreatText.text = ("Defensive Strength: " + AttackDefenceInfo[1]);



    }

    public void DisplayPossesionPlan()
    {
        PossesionBtn = GameObject.Find("PossesionBtn").GetComponent<Button>();
        GameplanCapabilityText.text = ("Gameplan Capability: " + MyModel.returnPossessionPlan(MyModel.SelectedSquad, MyModel.TeamManagedID));
        CurrentGameplanText.text = ("Possesion");

    }

    public void ViewCounterPlan()
    {

        CounterBtn = GameObject.Find("CounterBtn").GetComponent<Button>();
        GameplanCapabilityText.text = ("Gameplan Capability: " + MyModel.returnCounterPlan(MyModel.SelectedSquad, MyModel.TeamManagedID));
        CurrentGameplanText.text = ("Counter");

    }

    public void ViewPressurePlan()
    {
        PressureBtn = GameObject.Find("PressureBtn").GetComponent<Button>();
        GameplanCapabilityText.text = ("Gameplan Capability: " + MyModel.returnPressurePlan(MyModel.SelectedSquad, MyModel.TeamManagedID));
        CurrentGameplanText.text = ("Pressure");

    }



    public void UpdatePlayerInfo()
    {
        GameWeekTxt = GameObject.Find("GameWeekTxt").GetComponent<Text>();
        ManStressTxt = GameObject.Find("ManStressTxt").GetComponent<Text>();
        ManNameTxt = GameObject.Find("ManNameTxt").GetComponent<Text>();


        GameWeekTxt.text = ("Game Week: " + GameWeek);
        ManStressTxt.text = ("Stress Level: " + MyModel.ManStress);
        ManNameTxt.text = ("Name: " + MyModel.ManName);
    }




    public void CreateManager()
    {
        NameInpuField = GameObject.Find("NameInputField").GetComponent<InputField>();
        NationalityInputField = GameObject.Find("NationalityInputField").GetComponent<InputField>();

        string ManName = NameInpuField.text;

        string ManNat = NationalityInputField.text;

        MyModel.ManagerCreate(ManName, ManNat);


    }


    public void ChangeTeam()
    {
        string[] TeamSelectInfo = new string[5];


        NameText = GameObject.Find("NameText").GetComponent<Text>();
        ReputationText = GameObject.Find("ReputationText").GetComponent<Text>();
        BudgetText = GameObject.Find("BudgetText").GetComponent<Text>();
        AttackDefenceText = GameObject.Find("AttackDefenceText").GetComponent<Text>();
        GroundText = GameObject.Find("GroundText").GetComponent<Text>();

        TeamSelectInfo = MyModel.changeTeam();

        NameText.text = TeamSelectInfo[0];
        ReputationText.text = TeamSelectInfo[1];
        BudgetText.text = TeamSelectInfo[2];
        AttackDefenceText.text = TeamSelectInfo[3];
        GroundText.text = TeamSelectInfo[4];


    }

    public void SelectTeam()
    {

        MyModel.chooseTeam();


    }


    public void DisplayFaithPanel()
    {
        BoardText = GameObject.Find("BoardText").GetComponent<Text>();
        FanText = GameObject.Find("FanText").GetComponent<Text>();

        int[] Faith = new int[2];


        Faith = MyModel.getFaith();

        BoardText.text = ("Board Faith: " + Faith[0]);
        FanText.text = ("Fan Faith: " + Faith[1]);

    }

    public void DisplayPlayerInfo()
    {

        string[] playerinfo = new string[2];
        GameWeekTxt = GameObject.Find("GameWeekTxt").GetComponent<Text>();
        ManStressTxt = GameObject.Find("ManStressTxt").GetComponent<Text>();
        ManNameTxt = GameObject.Find("ManNameTxt").GetComponent<Text>();


        playerinfo = MyModel.getPlayerInfo();

        GameWeekTxt.text = "GameWeek: " + GameWeek;
        ManStressTxt.text = "Stress Level: " + playerinfo[1];
        ManNameTxt.text = "Head Coach: " + playerinfo[0];


    }

    public void DisplayPlayerStats()
    {
        DisplayPlayerInfo();
        DisplayFaithPanel();



    }


    public void CheckFaith()
    {
        DisplayPlayerInfo();
        DisplayFaithPanel();

        //MyModel.DecreaseFanFaith();

    }

    public void populateScorerTable()
    {

        MyModel.PopulateScorersTable();


    }


    public void InitialisePlayerTeam()
    {

        MyModel.InitPlayerTeam();



    }

    // Start is called before the first frame update
    void Start()
    {

        MyModel.InitModel();
    
    }
       




}
