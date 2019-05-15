using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;
using UnityEngine.SceneManagement;



public class Model : MonoBehaviour
{
    //Used to avoid a crash to do with the Team tab.
    public bool TableCrash = false;


    //variable used for calculating attack and defence for each team
    int AttackCount;
    int DefenceCount;


    //Variables required for manager creation and team selection.
    public int index = 0;
    public int TeamManagedID = 0;
    public string ManNationality;
    public string ManName;
    public int ManStress = 50;





    // List structures used to store player and team info.
    public List<PlayerInfo> playerinfo = new List<PlayerInfo>();
    public List<TeamInfo> teaminfo = new List<TeamInfo>();


    //Used for reading in data from a csv file.
    public TextAsset TeamData;
    public TextAsset PlayerData;



    //Required text objects for the team selection portion of the game.

    public Text PlayerWarnings;
    public Text SquadCapabilitiesText;

    public Button SToption1;
    public Button SToption2;
    public Button SToption3;

    public Button MFoption1;
    public Button MFoption2;
    public Button MFoption3;
    public Button MFoption4;
    public Button MFoption5;
    public Button MFoption6;

    public Button LeftMoption1;
    public Button LeftMoption2;

    public Button RightMoption1;
    public Button RightMoption2;

    public Button LBoption1;
    public Button LBoption2;

    public Button RBoption1;
    public Button RBoption2;

    public Button CBoption1;
    public Button CBoption2;
    public Button CBoption3;
    public Button CBoption4;

    public Button GKoption1;
    public Button GKoption2;
    public Button GKoption3;

    List<Button> GKTracker = new List<Button>();
    List<Button> RBTracker = new List<Button>();
    List<Button> LBTracker = new List<Button>();
    List<Button> CBTracker = new List<Button>();
    List<Button> RMTracker = new List<Button>();
    List<Button> LMTracker = new List<Button>();
    List<Button> STTracker = new List<Button>();
    List<Button> MFTracker = new List<Button>();


    public List<PlayerInfo> Starting11 = new List<PlayerInfo>();

    public int totalST = 0;
    public int totalCB = 0;
    public int totalMF = 0;
    public int totalRB = 0;
    public int totalLB = 0;
    public int totalLM = 0;
    public int totalRM = 0;
    public int totalGK = 0;
    public int TotalStarters = 0;



    public bool[] buttonPressedTracker = new bool[6];

    public bool[] CBpressed = new bool[4];
    public bool[] STpressed = new bool[3];

    public bool CBbtn1pressed = false;
    public bool RMbtn1pressed = false;
    public bool LMbtn1pressed = false;
    public bool RBbtn1pressed = false;
    public bool LBbtn1pressed = false;
    public bool GKbtn1pressed = false;


    public List<Starting11Info> Keepers = new List<Starting11Info>();
    public List<Starting11Info> CentreBacks = new List<Starting11Info>();
    List<Starting11Info> RightBacks = new List<Starting11Info>();
    List<Starting11Info> LeftBacks = new List<Starting11Info>();
    List<Starting11Info> MidFielders = new List<Starting11Info>();
    List<Starting11Info> LeftMid = new List<Starting11Info>();
    List<Starting11Info> RightMid = new List<Starting11Info>();
    List<Starting11Info> Striker = new List<Starting11Info>();

    public List<Starting11Info> SquadTracker = new List<Starting11Info>();

    //Used for displaying squad information.

    public Button NextBtn;
    public Button BackBtn;

    public Text NameHeader;
    public Text PositionHeader;
    public Text AgeHeader;
    public Text OverallHeader;
    public Text MoraleHeader;
    public Text FormHeader;
    public Button MoreInfoBtn;

    public Text NameHeader1;
    public Text PositionHeader1;
    public Text AgeHeader1;
    public Text OverallHeader1;
    public Text MoraleHeader1;
    public Text FormHeader1;
    public Button MoreInfoBtn1;

    public Text NameHeader2;
    public Text PositionHeader2;
    public Text AgeHeader2;
    public Text OverallHeader2;
    public Text MoraleHeader2;
    public Text FormHeader2;
    public Button MoreInfoBtn2;
    public int BoardFaith2;

    public Text NameHeader3;
    public Text PositionHeader3;
    public Text AgeHeader3;
    public Text OverallHeader3;
    public Text MoraleHeader3;
    public Text FormHeader3;
    public Button MoreInfoBtn3;

    public Text NameHeader4;
    public Text PositionHeader4;
    public Text AgeHeader4;
    public Text OverallHeader4;
    public Text MoraleHeader4;
    public Text FormHeader4;
    public Button MoreInfoBtn4;

    public Text NameHeader5;
    public Text PositionHeader5;
    public Text AgeHeader5;
    public Text OverallHeader5;
    public Text MoraleHeader5;
    public Text FormHeader5;
    public Button MoreInfoBtn5;

    public Text NameHeader6;
    public Text PositionHeader6;
    public Text AgeHeader6;
    public Text OverallHeader6;
    public Text MoraleHeader6;
    public Text FormHeader6;
    public Button MoreInfoBtn6;

    public Text NameHeader7;
    public Text PositionHeader7;
    public Text AgeHeader7;
    public Text OverallHeader7;
    public Text MoraleHeader7;
    public Text FormHeader7;
    public Button MoreInfoBtn7;

    public Text NameHeader8;
    public Text PositionHeader8;
    public Text AgeHeader8;
    public Text OverallHeader8;
    public Text MoraleHeader8;
    public Text FormHeader8;
    public Button MoreInfoBtn8;

    public Text NameHeader9;
    public Text PositionHeader9;
    public Text AgeHeader9;
    public Text OverallHeader9;
    public Text MoraleHeader9;
    public Text FormHeader9;
    public Button MoreInfoBtn9;

    public Text NameHeader10;
    public Text PositionHeader10;
    public Text AgeHeader10;
    public Text OverallHeader10;
    public Text MoraleHeader10;
    public Text FormHeader10;
    public Button MoreInfoBtn10;

    public Text NameHeader11;
    public Text PositionHeader11;
    public Text AgeHeader11;
    public Text OverallHeader11;
    public Text MoraleHeader11;
    public Text FormHeader11;
    public Button MoreInfoBtn11;

    public Text NameHeader12;
    public Text PositionHeader12;
    public Text AgeHeader12;
    public Text OverallHeader12;
    public Text MoraleHeader12;
    public Text FormHeader12;
    public Button MoreInfoBtn12;


    List<Text> Tlist = new List<Text>();
    List<Text> SquadAgeList = new List<Text>();
    List<Text> SquadOverallList = new List<Text>();
    List<Text> SquadFormList = new List<Text>();
    List<Text> SquadMoraleList = new List<Text>();
    List<Text> SquadPositionList = new List<Text>();
    List<Text> SquadNameList = new List<Text>();

    // Used for displaying table information
    public Text Pos0;
    public Text Pos1;
    public Text Pos2;
    public Text Pos3;
    public Text Pos4;
    public Text Pos5;
    public Text Pos6;
    public Text Pos7;
    public Text Pos8;
    public Text Pos9;
    public Text Pos10;
    public Text Pos11;

    public Text Team0;
    public Text Wins0;
    public Text Losses0;
    public Text Draws0;
    public Text Points0;

    public Text Team1;
    public Text Wins1;
    public Text Losses1;
    public Text Draws1;
    public Text Points1;

    public Text Team2;
    public Text Wins2;
    public Text Losses2;
    public Text Draws2;
    public Text Points2;

    public Text Team3;
    public Text Wins3;
    public Text Losses3;
    public Text Draws3;
    public Text Points3;

    public Text Team4;
    public Text Wins4;
    public Text Losses4;
    public Text Draws4;
    public Text Points4;

    public Text Team5;
    public Text Wins5;
    public Text Losses5;
    public Text Draws5;
    public Text Points5;

    public Text Team6;
    public Text Wins6;
    public Text Losses6;
    public Text Draws6;
    public Text Points6;

    public Text Team7;
    public Text Wins7;
    public Text Losses7;
    public Text Draws7;
    public Text Points7;

    public Text Team8;
    public Text Wins8;
    public Text Losses8;
    public Text Draws8;
    public Text Points8;

    public Text Team9;
    public Text Wins9;
    public Text Losses9;
    public Text Draws9;
    public Text Points9;

    public Text Team10;
    public Text Wins10;
    public Text Losses10;
    public Text Draws10;
    public Text Points10;

    public Text Team11;
    public Text Wins11;
    public Text Losses11;
    public Text Draws11;
    public Text Points11;


    List<Text> LeagueTeamList = new List<Text>();
    List<Text> LeagueWinsList = new List<Text>();
    List<Text> LeagueLossesList = new List<Text>();
    List<Text> LeagueDrawsList = new List<Text>();
    List<Text> LeaguePointsList = new List<Text>();


    // Used for displaying top scorers information.

    public Text ScorerPositionHeader0;
    public Text ScorerNameHeader0;
    public Text ScorerTeamHeader0;
    public Text ScorerGoalsScored0;

    public Text ScorerPositionHeader1;
    public Text ScorerNameHeader1;
    public Text ScorerTeamHeader1;
    public Text ScorerGoalsScored1;

    public Text ScorerPositionHeader2;
    public Text ScorerNameHeader2;
    public Text ScorerTeamHeader2;
    public Text ScorerGoalsScored2;

    public Text ScorerPositionHeader3;
    public Text ScorerNameHeader3;
    public Text ScorerTeamHeader3;
    public Text ScorerGoalsScored3;

    public Text ScorerPositionHeader4;
    public Text ScorerNameHeader4;
    public Text ScorerTeamHeader4;
    public Text ScorerGoalsScored4;



    List<Text> ScorerPositionList = new List<Text>();
    List<Text> ScorerNameList = new List<Text>();
    List<Text> ScorerTeamList = new List<Text>();
    List<Text> ScorerGoalsScored = new List<Text>();



    //Lists used to store data needed.

    public List<OppositionInfo> oppinfo = new List<OppositionInfo>();

    public List<PlayerInfo> SelectedSquad = new List<PlayerInfo>();

    public List<TableInfo> SortedTeams = new List<TableInfo>();

    public List<Text> SquadChoice;

    public List<TableInfo> TableStats = new List<TableInfo>();

    public List<MatchDayInfo> MatchStats = new List<MatchDayInfo>();



    // Used for calculation of team overalls.
    public int CurrentTeamOverall;
    public int CurrentTeamThreat;
    public int CurrentTeamDefence;
    public int CurrentTeamPossesion;
    public int CurrentTeamCounter;
    public int CurrentTeamPressure;


    

    // Used for matchday preparation.
    int[] HomeTeams = new int[] { 0, 2, 4, 6, 8, 10 };
    int[] AwayTeams = new int[] { 1, 3, 5, 7, 9, 11 };



    // Required to make sure random numbers are actually random.
    private static readonly System.Random rnd = new System.Random();
    private static object syncLock = new object();








    // Used to make sure players selected tactics are actually carried out.
    public int SelectedTactic = 0;




   

    //Taking in user input and assigning them to values to store for later.
    public void ManagerCreate(string NameInput, string NatInput)
    {

        ManName = NameInput;

        ManNationality = NatInput;


    }






    //Adds a player to a list of players that will be starting the match.

    public void AddToLineup(int PlayerID)
    {

        for (int i = 0; i <= 22; i++)
        {
            if (SelectedSquad[i].PlayerID == PlayerID)
            {

                Starting11.Add(SelectedSquad[i]);

            }

        }
        DisplayNewAttackDefence();
    }

    //Removing a player from a list of players that will be starting the match.

    public void RemoveFromLineup(int ToRemove)
    {

        for (int i = 0; i < Starting11.Count(); i++)
        {
            if (Starting11[i].PlayerID == ToRemove)
            {

                Starting11.RemoveAll(a => a.PlayerID == ToRemove);

            }

        }
        DisplayNewAttackDefence();
    }





    // Used to initialise the starting 11 selection screen for the player and makes sure specific positions are always used.
    public void InitialiseStarting11()
    {

 
        int ButtonID = 0;
        Starting11.Clear();

        // Adding crucial players to the lineup e.g. GK.
        for (int i = 0; i < buttonPressedTracker.Count(); i++)
        {
            buttonPressedTracker[i] = false;
            MFTracker[i].GetComponent<Image>().color = Color.white;
            MidFielders[i].Starting = false;
            totalMF = 0;
        }


        for (int i = 0; i < CBpressed.Count(); i++)
        {
            CBpressed[i] = false;
      
            CBTracker[i].GetComponent<Image>().color = Color.white;
            CentreBacks[i].Starting = false;
            totalCB = 0;
        }

        for (int i = 0; i < STpressed.Count(); i++)
        {
            STpressed[i] = false;
            STTracker[i].GetComponent<Image>().color = Color.white;
            Striker[i].Starting = false;
            totalST = 0;
        }



        AddToLineup(Keepers[0].PlayerID);

        GKTracker[ButtonID].GetComponent<Button>().interactable = false;
        GKTracker[ButtonID].GetComponent<Image>().color = Color.grey;
        Keepers[ButtonID].Starting = true;

        GKTracker[1].GetComponent<Button>().interactable = true;
        GKTracker[1].GetComponent<Image>().color = Color.white;
        Keepers[1].Starting = false;



        AddToLineup(LeftMid[0].PlayerID);

        LMTracker[ButtonID].GetComponent<Button>().interactable = false;
        LMTracker[ButtonID].GetComponent<Image>().color = Color.grey;
        LeftMid[ButtonID].Starting = true;

        LMTracker[1].GetComponent<Button>().interactable = true;
        LMTracker[1].GetComponent<Image>().color = Color.white;
        LeftMid[1].Starting = false;

        AddToLineup(RightMid[0].PlayerID);

        RMTracker[ButtonID].GetComponent<Button>().interactable = false;
        RMTracker[ButtonID].GetComponent<Image>().color = Color.grey;
        RightMid[ButtonID].Starting = true;

        RMTracker[1].GetComponent<Button>().interactable = true;
        RMTracker[1].GetComponent<Image>().color = Color.white;
        RightMid[1].Starting = false;

        AddToLineup(LeftBacks[0].PlayerID);

        LBTracker[ButtonID].GetComponent<Button>().interactable = false;
        LBTracker[ButtonID].GetComponent<Image>().color = Color.grey;
        LeftBacks[ButtonID].Starting = true;

        LBTracker[1].GetComponent<Button>().interactable = true;
        LBTracker[1].GetComponent<Image>().color = Color.white;
        LeftBacks[1].Starting = false;


        AddToLineup(RightBacks[0].PlayerID);

        RBTracker[ButtonID].GetComponent<Button>().interactable = false;
        RBTracker[ButtonID].GetComponent<Image>().color = Color.grey;
        RightBacks[ButtonID].Starting = true;

        RBTracker[1].GetComponent<Button>().interactable = true;
        RBTracker[1].GetComponent<Image>().color = Color.white;
        RightBacks[1].Starting = false;

    }



    //Adding a keeper to the starting11 list depending on the ID of each button pressed, and also deselecting the previously selected keeper.
    public void SelectGK(int ButtonID)
    {

        if (ButtonID == 0)
        {
            AddToLineup(Keepers[0].PlayerID);

            GKTracker[ButtonID].GetComponent<Button>().interactable = false;
            GKTracker[ButtonID].GetComponent<Image>().color = Color.grey;
            Keepers[ButtonID].Starting = true;

            GKTracker[1].GetComponent<Button>().interactable = true;
            GKTracker[1].GetComponent<Image>().color = Color.white;
            Keepers[1].Starting = false;

            for (int i = 0; i < Starting11.Count(); i++)
            {
                if (Starting11[i].PlayerID == Keepers[1].PlayerID)
                {
                    //var itemToRemove = Starting11.Single(r => r.PlayerID == Keepers[0].PlayerID);
                    //Starting11.Remove(itemToRemove);

                    Starting11.RemoveAll(a => a.PlayerID == Keepers[1].PlayerID);
                }


            }

  

        }



        if (ButtonID == 1)
        {

            AddToLineup(Keepers[ButtonID].PlayerID);
            GKTracker[ButtonID].GetComponent<Button>().interactable = false;
            GKTracker[ButtonID].GetComponent<Image>().color = Color.grey;
            Keepers[ButtonID].Starting = true;

            GKTracker[0].GetComponent<Button>().interactable = true;
            GKTracker[0].GetComponent<Image>().color = Color.white;
            Keepers[0].Starting = false;


            for (int i = 0; i < Starting11.Count(); i++)
            {
                if (Starting11[i].PlayerID == Keepers[0].PlayerID)
                {
                    //var itemToRemove = Starting11.Single(r => r.PlayerID == Keepers[0].PlayerID);
                    //Starting11.Remove(itemToRemove);
                    Starting11.RemoveAll(a => a.PlayerID == Keepers[0].PlayerID);
                }


            }



        }






    }




    //Adding a LM to the starting11 list depending on the ID of each button pressed, and also deselecting the previously selected LM.

    public void SelectLM(int ButtonID)
    {
        if (ButtonID == 0)
        {
            AddToLineup(LeftMid[0].PlayerID);

            LMTracker[ButtonID].GetComponent<Button>().interactable = false;
            LMTracker[ButtonID].GetComponent<Image>().color = Color.grey;
            LeftMid[ButtonID].Starting = true;

            LMTracker[1].GetComponent<Button>().interactable = true;
            LMTracker[1].GetComponent<Image>().color = Color.white;
            LeftMid[1].Starting = false;

            for (int i = 0; i < Starting11.Count(); i++)
            {
                if (Starting11[i].PlayerID == LeftMid[1].PlayerID)
                {
                    //var itemToRemove = Starting11.Single(r => r.PlayerID == LeftMid[0].PlayerID);
                    //Starting11.Remove(itemToRemove);

                    Starting11.RemoveAll(a => a.PlayerID == LeftMid[1].PlayerID);
                }
                else
                {
                    PlayerWarnings.text = ("You should only be playing 1 wide attacking player attacking player at a time on each side ");


                }


            }



        }



        if (ButtonID == 1)
        {

            AddToLineup(LeftMid[ButtonID].PlayerID);
            LMTracker[ButtonID].GetComponent<Button>().interactable = false;
            LMTracker[ButtonID].GetComponent<Image>().color = Color.grey;
            LeftMid[ButtonID].Starting = true;

            LMTracker[0].GetComponent<Button>().interactable = true;
            LMTracker[0].GetComponent<Image>().color = Color.white;
            LeftMid[0].Starting = false;


            for (int i = 0; i < Starting11.Count(); i++)
            {
                if (Starting11[i].PlayerID == LeftMid[0].PlayerID)
                {
                    //var itemToRemove = Starting11.Single(r => r.PlayerID == LeftMid[0].PlayerID);
                    //Starting11.Remove(itemToRemove);
                    Starting11.RemoveAll(a => a.PlayerID == LeftMid[0].PlayerID);
                }
                else
                {
                    PlayerWarnings.text = ("You should only be playing 1 wide attacking player attacking player at a time on each side ");


                }

            }




        }

    }
    //Adding a RM to the starting11 list depending on the ID of each button pressed, and also deselecting the previously selected RM.

    public void SelectRM(int ButtonID)
    {
        if (ButtonID == 0)
        {
            AddToLineup(RightMid[0].PlayerID);

            RMTracker[ButtonID].GetComponent<Button>().interactable = false;
            RMTracker[ButtonID].GetComponent<Image>().color = Color.grey;
            RightMid[ButtonID].Starting = true;

            RMTracker[1].GetComponent<Button>().interactable = true;
            RMTracker[1].GetComponent<Image>().color = Color.white;
            RightMid[1].Starting = false;

            for (int i = 0; i < Starting11.Count(); i++)
            {
                if (Starting11[i].PlayerID == RightMid[1].PlayerID)
                {
                    //var itemToRemove = Starting11.Single(r => r.PlayerID == RightMid[0].PlayerID);
                    //Starting11.Remove(itemToRemove);

                    Starting11.RemoveAll(a => a.PlayerID == RightMid[1].PlayerID);
                }
                else
                {
                    PlayerWarnings.text = ("You should only be playing 1 wide attacking player attacking player at a time on each side ");


                }


            }

  

        }



        if (ButtonID == 1)
        {

            AddToLineup(RightMid[ButtonID].PlayerID);
            RMTracker[ButtonID].GetComponent<Button>().interactable = false;
            RMTracker[ButtonID].GetComponent<Image>().color = Color.grey;
            RightMid[ButtonID].Starting = true;

            RMTracker[0].GetComponent<Button>().interactable = true;
            RMTracker[0].GetComponent<Image>().color = Color.white;
            RightMid[0].Starting = false;


            for (int i = 0; i < Starting11.Count(); i++)
            {
                if (Starting11[i].PlayerID == RightMid[0].PlayerID)
                {
                    //var itemToRemove = Starting11.Single(r => r.PlayerID == RightMid[0].PlayerID);
                    //Starting11.Remove(itemToRemove);
                    Starting11.RemoveAll(a => a.PlayerID == RightMid[0].PlayerID);
                }
                else
                {
                    PlayerWarnings.text = ("You should only be playing 1 wide attacking player attacking player at a time on each side ");


                }

            }



        }

    }













    // Players are allowed to select as many players in this position as they want as long as there is less than 11 players already in the starting lineup.
public void SelectST(int ButtonID)
    {


        if (Starting11.Count == 11 && STpressed[ButtonID] == true)
        {
            RemoveFromLineup(Striker[ButtonID].PlayerID);
            STTracker[ButtonID].GetComponent<Image>().color = Color.white;
            Striker[ButtonID].Starting = false;
            totalST--;
            STpressed[ButtonID] = false;
        }

        else if (Starting11.Count == 11 && STpressed[ButtonID] == false)
        {
            PlayerWarnings.text = ("You can only field a maximum of 11 players at a time");
            STTracker[ButtonID].GetComponent<Image>().color = Color.white;
            Striker[ButtonID].Starting = false;
            STpressed[ButtonID] = false;
        }

        else if (STpressed[ButtonID] == true && Starting11.Count != 11)
        {
            RemoveFromLineup(Striker[ButtonID].PlayerID);
            STTracker[ButtonID].GetComponent<Image>().color = Color.white;
            Striker[ButtonID].Starting = false;
            totalST--;
            STpressed[ButtonID] = false;

        }
        else if (STpressed[ButtonID] == false && Starting11.Count != 11)
        {
            AddToLineup(Striker[ButtonID].PlayerID);
            STTracker[ButtonID].GetComponent<Image>().color = Color.grey;
            Striker[ButtonID].Starting = true;

            totalST++;
            STpressed[ButtonID] = true;
        }




    }



    //Adding a LB to the starting11 list depending on the ID of each button pressed, and also deselecting the previously selected LB.


    public void SelectLB(int ButtonID)
    {
        if (ButtonID == 0)
        {
            AddToLineup(LeftBacks[0].PlayerID);

            LBTracker[ButtonID].GetComponent<Button>().interactable = false;
            LBTracker[ButtonID].GetComponent<Image>().color = Color.grey;
            LeftBacks[ButtonID].Starting = true;

            LBTracker[1].GetComponent<Button>().interactable = true;
            LBTracker[1].GetComponent<Image>().color = Color.white;
            LeftBacks[1].Starting = false;

            for (int i = 0; i < Starting11.Count(); i++)
            {
                if (Starting11[i].PlayerID == LeftBacks[1].PlayerID)
                {
                    //var itemToRemove = Starting11.Single(r => r.PlayerID == LeftBack[0].PlayerID);
                    //Starting11.Remove(itemToRemove);

                    Starting11.RemoveAll(a => a.PlayerID == LeftBacks[1].PlayerID);
                }


            }

            Debug.Log("new list");
            for (int i = 0; i < Starting11.Count(); i++)
            {

                Debug.Log(Starting11[i].Name + Starting11[i].Position);

            }

        }



        if (ButtonID == 1)
        {

            AddToLineup(LeftBacks[ButtonID].PlayerID);
            LBTracker[ButtonID].GetComponent<Button>().interactable = false;
            LBTracker[ButtonID].GetComponent<Image>().color = Color.grey;
            LeftBacks[ButtonID].Starting = true;

            LBTracker[0].GetComponent<Button>().interactable = true;
            LBTracker[0].GetComponent<Image>().color = Color.white;
            LeftBacks[0].Starting = false;


            for (int i = 0; i < Starting11.Count(); i++)
            {
                if (Starting11[i].PlayerID == LeftBacks[0].PlayerID)
                {
                    //var itemToRemove = Starting11.Single(r => r.PlayerID == LeftBack[0].PlayerID);
                    //Starting11.Remove(itemToRemove);
                    Starting11.RemoveAll(a => a.PlayerID == LeftBacks[0].PlayerID);
                }


            }


            Debug.Log("new list");
            for (int i = 0; i < Starting11.Count(); i++)
            {

                Debug.Log(Starting11[i].Name + Starting11[i].Position);

            }

        }









    }

    //Adding a RB to the starting11 list depending on the ID of each button pressed, and also deselecting the previously selected RB.


    public void SelectRB(int ButtonID)
    {

        if (ButtonID == 0)
        {
            AddToLineup(RightBacks[0].PlayerID);

            RBTracker[ButtonID].GetComponent<Button>().interactable = false;
            RBTracker[ButtonID].GetComponent<Image>().color = Color.grey;
            RightBacks[ButtonID].Starting = true;

            RBTracker[1].GetComponent<Button>().interactable = true;
            RBTracker[1].GetComponent<Image>().color = Color.white;
            RightBacks[1].Starting = false;

            for (int i = 0; i < Starting11.Count(); i++)
            {
                if (Starting11[i].PlayerID == RightBacks[1].PlayerID)
                {
                    //var itemToRemove = Starting11.Single(r => r.PlayerID == LeftBack[0].PlayerID);
                    //Starting11.Remove(itemToRemove);

                    Starting11.RemoveAll(a => a.PlayerID == RightBacks[1].PlayerID);
                }


            }

            Debug.Log("new list");
            for (int i = 0; i < Starting11.Count(); i++)
            {

                Debug.Log(Starting11[i].Name + Starting11[i].Position);

            }

        }



        if (ButtonID == 1)
        {

            AddToLineup(RightBacks[ButtonID].PlayerID);
            RBTracker[ButtonID].GetComponent<Button>().interactable = false;
            RBTracker[ButtonID].GetComponent<Image>().color = Color.grey;
            RightBacks[ButtonID].Starting = true;

            RBTracker[0].GetComponent<Button>().interactable = true;
            RBTracker[0].GetComponent<Image>().color = Color.white;
            RightBacks[0].Starting = false;


            for (int i = 0; i < Starting11.Count(); i++)
            {
                if (Starting11[i].PlayerID == RightBacks[0].PlayerID)
                {
                    //var itemToRemove = Starting11.Single(r => r.PlayerID == LeftBack[0].PlayerID);
                    //Starting11.Remove(itemToRemove);
                    Starting11.RemoveAll(a => a.PlayerID == RightBacks[0].PlayerID);
                }


            }


            Debug.Log("new list");
            for (int i = 0; i < Starting11.Count(); i++)
            {

                Debug.Log(Starting11[i].Name + Starting11[i].Position);

            }

        }




    }

    // Players are allowed to select as many players in this position as they want as long as there is less than 11 players already in the starting lineup.

    public void SelectCB(int ButtonID)
    {

        PlayerWarnings.text = "Choose 11 players to start";

        if (Starting11.Count == 11 && CBpressed[ButtonID] == true)
        {
            RemoveFromLineup(CentreBacks[ButtonID].PlayerID);
            CBTracker[ButtonID].GetComponent<Image>().color = Color.white;
            CentreBacks[ButtonID].Starting = false;
            totalCB--;
            CBpressed[ButtonID] = false;
        }

        else if (Starting11.Count == 11 && CBpressed[ButtonID] == false)
        {
            PlayerWarnings.text = ("You can only field a maximum of 11 players at a time");
            CBTracker[ButtonID].GetComponent<Image>().color = Color.white;
            CentreBacks[ButtonID].Starting = false;
            CBpressed[ButtonID] = false;
        }

        else if (CBpressed[ButtonID] == true && Starting11.Count != 11)
        {
            RemoveFromLineup(CentreBacks[ButtonID].PlayerID);
            CBTracker[ButtonID].GetComponent<Image>().color = Color.white;
            CentreBacks[ButtonID].Starting = false;
            totalCB--;
            CBpressed[ButtonID] = false;

        }
        else if (CBpressed[ButtonID] == false && Starting11.Count != 11)
        {
            AddToLineup(CentreBacks[ButtonID].PlayerID);
            CBTracker[ButtonID].GetComponent<Image>().color = Color.grey;
            CentreBacks[ButtonID].Starting = true;

            totalCB++;
            CBpressed[ButtonID] = true;
        }


    }
    // Players are allowed to select as many players in this position as they want as long as there is less than 11 players already in the starting lineup.


    public void SelectMF(int ButtonID)
    {

        if (Starting11.Count == 11 && buttonPressedTracker[ButtonID] == true)
        {
            RemoveFromLineup(MidFielders[ButtonID].PlayerID);
            MFTracker[ButtonID].GetComponent<Image>().color = Color.white;
            MidFielders[ButtonID].Starting = false;
            totalMF--;
            buttonPressedTracker[ButtonID] = false;
        }

        else if (Starting11.Count == 11 && buttonPressedTracker[ButtonID] == false)
        {
            PlayerWarnings.text = ("You can only field a maximum of 11 players at a time");
            MFTracker[ButtonID].GetComponent<Image>().color = Color.white;
            MidFielders[ButtonID].Starting = false;
            buttonPressedTracker[ButtonID] = false;
        }

         else if (buttonPressedTracker[ButtonID] == true && Starting11.Count != 11)
        {
            RemoveFromLineup(MidFielders[ButtonID].PlayerID);
            MFTracker[ButtonID].GetComponent<Image>().color = Color.white;
            MidFielders[ButtonID].Starting = false;
            totalMF--;
            buttonPressedTracker[ButtonID] = false;

        }
        else if (buttonPressedTracker[ButtonID] == false && Starting11.Count != 11)
        {
            AddToLineup(MidFielders[ButtonID].PlayerID);
            MFTracker[ButtonID].GetComponent<Image>().color = Color.grey;
            MidFielders[ButtonID].Starting = true;

            totalMF++;
            buttonPressedTracker[ButtonID] = true;
        }

    }

    //Displaying which available players there are to be selected for the user per position.

    public void displayPlayers(List<Starting11Info> playerTracker, List<Button> buttons)
    {
        for (int i = 0; i < playerTracker.Count(); i++)
        {

            buttons[i].GetComponentInChildren<Text>().text = playerTracker[i].Name + "\n " + playerTracker[i].Overall;


            if (playerTracker[i].Overall >= 85)
            {
                buttons[i].GetComponentInChildren<Text>().color = Color.red;
            }


        }

    }



    //Retrieving which players can be selected and calling the displayPlayerrs function to display them.

    public void displayOptions()
    {

        PlayerWarnings = GameObject.Find("PlayerWarnings").GetComponent<Text>();
        SquadCapabilitiesText = GameObject.Find("SquadCapabilitiesText").GetComponent<Text>();


        SToption1 = GameObject.Find("SToption1").GetComponent<Button>();
        SToption2 = GameObject.Find("SToption2").GetComponent<Button>();
        SToption3 = GameObject.Find("SToption3").GetComponent<Button>();

        MFoption1 = GameObject.Find("MFoption1").GetComponent<Button>();
        MFoption2 = GameObject.Find("MFoption2").GetComponent<Button>();
        MFoption3 = GameObject.Find("MFoption3").GetComponent<Button>();
        MFoption4 = GameObject.Find("MFoption4").GetComponent<Button>();
        MFoption5 = GameObject.Find("MFoption5").GetComponent<Button>();
        MFoption6 = GameObject.Find("MFoption6").GetComponent<Button>();

        LeftMoption1 = GameObject.Find("LMoption1").GetComponent<Button>();
        LeftMoption2 = GameObject.Find("LMoption2").GetComponent<Button>();

        RightMoption1 = GameObject.Find("RMoption1").GetComponent<Button>();
        RightMoption2 = GameObject.Find("RMoption2").GetComponent<Button>();

        LBoption1 = GameObject.Find("LBoption1").GetComponent<Button>();
        LBoption2 = GameObject.Find("LBoption2").GetComponent<Button>();

        RBoption1 = GameObject.Find("RBoption1").GetComponent<Button>();
        RBoption2 = GameObject.Find("RBoption2").GetComponent<Button>();


        CBoption1 = GameObject.Find("CBoption1").GetComponent<Button>();
        CBoption2 = GameObject.Find("CBoption2").GetComponent<Button>();
        CBoption3 = GameObject.Find("CBoption3").GetComponent<Button>();
        CBoption4 = GameObject.Find("CBoption4").GetComponent<Button>();


        GKoption1 = GameObject.Find("GKoption1").GetComponent<Button>();
        GKoption2 = GameObject.Find("GKoption2").GetComponent<Button>();
        // adding the buttons to lists so they are easier to keep track of.
        STTracker.Add(SToption1);
        STTracker.Add(SToption2);
        STTracker.Add(SToption3);
        MFTracker.Add(MFoption1);
        MFTracker.Add(MFoption2);
        MFTracker.Add(MFoption3);
        MFTracker.Add(MFoption4);
        MFTracker.Add(MFoption5);
        MFTracker.Add(MFoption6);
        LMTracker.Add(LeftMoption1);
        LMTracker.Add(LeftMoption2);
        RMTracker.Add(RightMoption1);
        RMTracker.Add(RightMoption2);
        LBTracker.Add(LBoption1);
        LBTracker.Add(LBoption2);
        RBTracker.Add(RBoption1);
        RBTracker.Add(RBoption2);
        CBTracker.Add(CBoption1);
        CBTracker.Add(CBoption2);
        CBTracker.Add(CBoption3);
        CBTracker.Add(CBoption4);
        GKTracker.Add(GKoption1);
        GKTracker.Add(GKoption2);

        for (int i = 0; i <= 22; i++)
        {

            if (SelectedSquad[i].Position == "GK")
            {
                Starting11Info t = new Starting11Info();
                t.Name = SelectedSquad[i].Name;
                t.Overall = SelectedSquad[i].Overall;
                t.Position = SelectedSquad[i].Position;
                t.PlayerID = SelectedSquad[i].PlayerID;
                t.Form = SelectedSquad[i].Form;
                t.Starting = false;
                Keepers.Add(t);
            }

            if (SelectedSquad[i].Position == "CB")
            {
                Starting11Info t = new Starting11Info();
                t.Name = SelectedSquad[i].Name;
                t.Overall = SelectedSquad[i].Overall;
                t.Position = SelectedSquad[i].Position;
                t.PlayerID = SelectedSquad[i].PlayerID;
                t.Form = SelectedSquad[i].Form;
                t.Starting = false;
                CentreBacks.Add(t);
            }

            if (SelectedSquad[i].Position == "LB")
            {
                Starting11Info t = new Starting11Info();
                t.Name = SelectedSquad[i].Name;
                t.Overall = SelectedSquad[i].Overall;
                t.Position = SelectedSquad[i].Position;
                t.PlayerID = SelectedSquad[i].PlayerID;
                t.Form = SelectedSquad[i].Form;
                t.Starting = false;
                LeftBacks.Add(t);
            }

            if (SelectedSquad[i].Position == "RB")
            {
                Starting11Info t = new Starting11Info();
                t.Name = SelectedSquad[i].Name;
                t.Overall = SelectedSquad[i].Overall;
                t.Position = SelectedSquad[i].Position;
                t.PlayerID = SelectedSquad[i].PlayerID;
                t.Form = SelectedSquad[i].Form;
                t.Starting = false;
                RightBacks.Add(t);
            }

            if (SelectedSquad[i].Position == "CM")
            {
                Starting11Info t = new Starting11Info();
                t.Name = SelectedSquad[i].Name;
                t.Overall = SelectedSquad[i].Overall;
                t.Position = SelectedSquad[i].Position;
                t.PlayerID = SelectedSquad[i].PlayerID;
                t.Form = SelectedSquad[i].Form;
                t.Starting = false;
                MidFielders.Add(t);
            }

            if (SelectedSquad[i].Position == "CAM")
            {
                Starting11Info t = new Starting11Info();
                t.Name = SelectedSquad[i].Name;
                t.Overall = SelectedSquad[i].Overall;
                t.Position = SelectedSquad[i].Position;
                t.PlayerID = SelectedSquad[i].PlayerID;
                t.Form = SelectedSquad[i].Form;
                t.Starting = false;
                MidFielders.Add(t);
            }

            if (SelectedSquad[i].Position == "CDM")
            {
                Starting11Info t = new Starting11Info();
                t.Name = SelectedSquad[i].Name;
                t.Overall = SelectedSquad[i].Overall;
                t.Position = SelectedSquad[i].Position;
                t.PlayerID = SelectedSquad[i].PlayerID;
                t.Form = SelectedSquad[i].Form;
                t.Starting = false;
                MidFielders.Add(t);
            }

            if (SelectedSquad[i].Position == "LM")
            {
                Starting11Info t = new Starting11Info();
                t.Name = SelectedSquad[i].Name;
                t.Overall = SelectedSquad[i].Overall;
                t.Position = SelectedSquad[i].Position;
                t.PlayerID = SelectedSquad[i].PlayerID;
                t.Form = SelectedSquad[i].Form;
                t.Starting = false;
                LeftMid.Add(t);
            }

            if (SelectedSquad[i].Position == "RM")
            {
                Starting11Info t = new Starting11Info();
                t.Name = SelectedSquad[i].Name;
                t.Overall = SelectedSquad[i].Overall;
                t.Position = SelectedSquad[i].Position;
                t.PlayerID = SelectedSquad[i].PlayerID;
                t.Form = SelectedSquad[i].Form;
                t.Starting = false;
                RightMid.Add(t);
            }
            if (SelectedSquad[i].Position == "ST")
            {
                Starting11Info t = new Starting11Info();
                t.Name = SelectedSquad[i].Name;
                t.Overall = SelectedSquad[i].Overall;
                t.Position = SelectedSquad[i].Position;
                t.PlayerID = SelectedSquad[i].PlayerID;
                t.Form = SelectedSquad[i].Form;
                t.Starting = false;
                Striker.Add(t);
            }


        }
        displayPlayers(MidFielders, MFTracker);
        displayPlayers(Keepers, GKTracker);

        displayPlayers(CentreBacks, CBTracker);

        displayPlayers(LeftBacks, LBTracker);

        displayPlayers(RightBacks, RBTracker);


        displayPlayers(RightMid, RMTracker);

        displayPlayers(LeftMid, LMTracker);

        displayPlayers(Striker, STTracker);

    }



    //Checking if the user has won or lost the game and returning a value based on this.
    public int LossCondition(int GameWeek)
    {
        if (ManStress > 80)
        {
            return 0;
        }
        //Faith is too low causing the loss condition.
        if (teaminfo[TeamManagedID].FanDiff < 20 || teaminfo[TeamManagedID].FanDiff < 20)
        {
            return 1;
        }

        if (GameWeek == 22)
        {
            return 3;
                    
        }
        //Nothing is to happen.
        else return 2;
    }




    //Restarts the scene thus restarting the gam.
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }





    // calls methods to retrive stats and displays them
    public void DisplayNewAttackDefence()
    {
        if (Starting11.Count >= 8)
        {
            SquadCapabilitiesText.text = "Attacking Threat: " + OppositionAttackThreat(Starting11, TeamManagedID) + "    Defensive Threat: " + OppositionDefenceThreat(Starting11, TeamManagedID);

        }

    }

    // calculates a value based on the stats of each player in the list of classes, CurrSquad.
    public int returnPossessionPlan(List<PlayerInfo> CurrSquad, int teamid)
    {


        int PossesionTotal = 0;
        int Possesioncounter = 0;
        int i = 0;
        List<int> PossesionAverage = new List<int>();



        // ball retention is the most important part of this gameplan and that is what is taken into account.
        for (i = 0; i <= 22; i++)
        {
            PossesionTotal = 0;
            PossesionTotal = PossesionTotal + CurrSquad[i].Passing;
            PossesionTotal = PossesionTotal + CurrSquad[i].Dribbling;
            PossesionAverage.Add(PossesionTotal / 2);
        }


        for (i = 0; i < PossesionAverage.Count(); i++)
        {
            Possesioncounter = Possesioncounter + PossesionAverage[i];

        }

        CurrentTeamPossesion = Possesioncounter / PossesionAverage.Count();

        SelectedTactic = CurrentTeamPossesion;

        return CurrentTeamPossesion;


    }



    // calculates a value based on the stats of each player in the list of classes, CurrSquad.

    public int returnCounterPlan(List<PlayerInfo> CurrSquad, int teamid)
    {
        int CounterTotal = 0;
        int Countercounter = 0;
        int i = 0;
        List<int> CounterAverage = new List<int>();

        for (i = 0; i <= 22; i++)
        {
            // Strikers need to be fast and clinical with their finishing in the counter, and this is what is taken into account.
            if (CurrSquad[i].Position == "ST")
            {
                CounterTotal = 0;
                CounterTotal = CounterTotal + CurrSquad[i].Pace;
                CounterTotal = CounterTotal + CurrSquad[i].Dribbling;
                CounterTotal = CounterTotal + CurrSquad[i].Shooting;
                CounterAverage.Add(CounterTotal / 3);
            }
            //Really wingers dont need to be as clinical as strikers as they should be the ones getting them ball.
            //Which is why wingers are only judged on their pace and dribbling in a counter attack.
            if (CurrSquad[i].Position == "LM")
            {
                CounterTotal = 0;
                CounterTotal = CounterTotal + CurrSquad[i].Pace;
                CounterTotal = CounterTotal + CurrSquad[i].Dribbling;
                CounterAverage.Add(CounterTotal / 2);
            }

            if (CurrSquad[i].Position == "RM")
            {
                CounterTotal = 0;
                CounterTotal = CounterTotal + CurrSquad[i].Pace;
                CounterTotal = CounterTotal + CurrSquad[i].Dribbling;
                CounterAverage.Add(CounterTotal / 2);
            }

            //Centre backs are vital in the counter as they are the ones usually winning back the ball and initiating the counter.
            if (CurrSquad[i].Position == "CB")
            {
                CounterTotal = 0;
                CounterTotal = CounterTotal + CurrSquad[i].Tackling;
                CounterTotal = CounterTotal + CurrSquad[i].Dribbling;
                CounterAverage.Add(CounterTotal / 2);
            }



        }


        for (i = 0; i < CounterAverage.Count(); i++)
        {
            Countercounter = Countercounter + CounterAverage[i];

        }

        CurrentTeamCounter = Countercounter / CounterAverage.Count();

        SelectedTactic = CurrentTeamCounter;

        return CurrentTeamCounter;



    }




    // calculates a value based on the stats of each player in the list of classes, CurrSquad.

    public int returnPressurePlan(List<PlayerInfo> CurrSquad, int teamid)
    {

        int PressureTotal = 0;
        int Pressurecounter = 0;
        int i = 0;
        List<int> PressureAverage = new List<int>();

        for (i = 0; i <= 22; i++)
        {


            //The whole team needs to be decent at tackling and be fit to be good at pressuring the opposition into a mistake.
            if (CurrSquad[i].Position != "GK")
            {
                PressureTotal = 0;
                PressureTotal = PressureTotal + CurrSquad[i].Physical;
                PressureTotal = PressureTotal + CurrSquad[i].Tackling;
                PressureAverage.Add(PressureTotal / 2);
            }


        }


        for (i = 0; i < PressureAverage.Count(); i++)
        {
            Pressurecounter = Pressurecounter + PressureAverage[i];

        }

        CurrentTeamPressure = Pressurecounter / PressureAverage.Count();


        SelectedTactic = CurrentTeamPressure;


        return CurrentTeamPressure;




    }




    //Finding the average of overall of the users team.
    public int CalculateCurrOverall()
    {
        int total = 0;
        //CurrentTeamOverall
        for (int i = 0; i <= 22; i++)
        {
            total = total + SelectedSquad[i].Overall;

        }

        CurrentTeamOverall = total / 23;

        return CurrentTeamOverall;

    }

    //Adding the text objects to lists and then using a loop to display these correctly
    public void PopulateScorersTable()
    {
        List<PlayerInfo> SortedPlayers = new List<PlayerInfo>();

        SortedPlayers = playerinfo.OrderByDescending(x => x.Goals).ToList();


        ScorerPositionHeader0 = GameObject.Find("ScorerPositionHeader (0)").GetComponent<Text>(); 
        ScorerNameHeader0 = GameObject.Find("ScorerNameHeader (0)").GetComponent<Text>();
        ScorerTeamHeader0 = GameObject.Find("ScorerTeamHeader (0)").GetComponent<Text>(); 
        ScorerGoalsScored0 = GameObject.Find("ScorerGoalsScored (0)").GetComponent<Text>();

        ScorerPositionList.Add(ScorerPositionHeader0);
        ScorerNameList.Add(ScorerNameHeader0);
        ScorerTeamList.Add(ScorerTeamHeader0);
        ScorerGoalsScored.Add(ScorerGoalsScored0);


        ScorerPositionHeader1 = GameObject.Find("ScorerPositionHeader (1)").GetComponent<Text>();
        ScorerNameHeader1 = GameObject.Find("ScorerNameHeader (1)").GetComponent<Text>();
        ScorerTeamHeader1 = GameObject.Find("ScorerTeamHeader (1)").GetComponent<Text>();
        ScorerGoalsScored1 = GameObject.Find("ScorerGoalsScored (1)").GetComponent<Text>();

        ScorerPositionList.Add(ScorerPositionHeader1);
        ScorerNameList.Add(ScorerNameHeader1);
        ScorerTeamList.Add(ScorerTeamHeader1);
        ScorerGoalsScored.Add(ScorerGoalsScored1);

        ScorerPositionHeader2 = GameObject.Find("ScorerPositionHeader (2)").GetComponent<Text>();
        ScorerNameHeader2 = GameObject.Find("ScorerNameHeader (2)").GetComponent<Text>();
        ScorerTeamHeader2 = GameObject.Find("ScorerTeamHeader (2)").GetComponent<Text>();
        ScorerGoalsScored2 = GameObject.Find("ScorerGoalsScored (2)").GetComponent<Text>();

        ScorerPositionList.Add(ScorerPositionHeader2);
        ScorerNameList.Add(ScorerNameHeader2);
        ScorerTeamList.Add(ScorerTeamHeader2);
        ScorerGoalsScored.Add(ScorerGoalsScored2);

        ScorerPositionHeader3 = GameObject.Find("ScorerPositionHeader (3)").GetComponent<Text>();
        ScorerNameHeader3 = GameObject.Find("ScorerNameHeader (3)").GetComponent<Text>();
        ScorerTeamHeader3 = GameObject.Find("ScorerTeamHeader (3)").GetComponent<Text>();
        ScorerGoalsScored3 = GameObject.Find("ScorerGoalsScored (3)").GetComponent<Text>();

        ScorerPositionList.Add(ScorerPositionHeader3);
        ScorerNameList.Add(ScorerNameHeader3);
        ScorerTeamList.Add(ScorerTeamHeader3);
        ScorerGoalsScored.Add(ScorerGoalsScored3);

        ScorerPositionHeader4 = GameObject.Find("ScorerPositionHeader (4)").GetComponent<Text>();
        ScorerNameHeader4 = GameObject.Find("ScorerNameHeader (4)").GetComponent<Text>();
        ScorerTeamHeader4 = GameObject.Find("ScorerTeamHeader (4)").GetComponent<Text>();
        ScorerGoalsScored4 = GameObject.Find("ScorerGoalsScored (4)").GetComponent<Text>();

        ScorerPositionList.Add(ScorerPositionHeader4);
        ScorerNameList.Add(ScorerNameHeader4);
        ScorerTeamList.Add(ScorerTeamHeader4);
        ScorerGoalsScored.Add(ScorerGoalsScored4);

        for (int i = 0; i <= 4; i++)
        {

            ScorerPositionList[i].text = SortedPlayers[i].Position;
            ScorerNameList[i].text = SortedPlayers[i].Name;
            ScorerTeamList[i].text = teaminfo[SortedPlayers[i].TeamID].Name;
            ScorerGoalsScored[i].text = SortedPlayers[i].Goals.ToString();

        }
    }

    //Adding the text objects to lists and then using a loop to display these correctly

    public void PopulateTable()
    {

        Team0 = GameObject.Find("Team (0)").GetComponent<Text>();
        Wins0 = GameObject.Find("Wins (0)").GetComponent<Text>();
        Losses0 = GameObject.Find("Losses (0)").GetComponent<Text>();
        Draws0 = GameObject.Find("Draws (0)").GetComponent<Text>();
        Points0 = GameObject.Find("Points (0)").GetComponent<Text>();

        LeagueTeamList.Add(Team0);
        LeagueWinsList.Add(Wins0);
        LeagueLossesList.Add(Losses0);
        LeagueDrawsList.Add(Draws0);
        LeaguePointsList.Add(Points0);


        Team1 = GameObject.Find("Team (1)").GetComponent<Text>();
        Wins1 = GameObject.Find("Wins (1)").GetComponent<Text>();
        Losses1 = GameObject.Find("Losses (1)").GetComponent<Text>();
        Draws1 = GameObject.Find("Draws (1)").GetComponent<Text>();
        Points1 = GameObject.Find("Points (1)").GetComponent<Text>();

        LeagueTeamList.Add(Team1);
        LeagueWinsList.Add(Wins1);
        LeagueLossesList.Add(Losses1);
        LeagueDrawsList.Add(Draws1);
        LeaguePointsList.Add(Points1);





        Team2 = GameObject.Find("Team (2)").GetComponent<Text>();
        Wins2 = GameObject.Find("Wins (2)").GetComponent<Text>();
        Losses2 = GameObject.Find("Losses (2)").GetComponent<Text>();
        Draws2 = GameObject.Find("Draws (2)").GetComponent<Text>();
        Points2 = GameObject.Find("Points (2)").GetComponent<Text>();

        LeagueTeamList.Add(Team2);
        LeagueWinsList.Add(Wins2);
        LeagueLossesList.Add(Losses2);
        LeagueDrawsList.Add(Draws2);
        LeaguePointsList.Add(Points2);


        Team3 = GameObject.Find("Team (3)").GetComponent<Text>();
        Wins3 = GameObject.Find("Wins (3)").GetComponent<Text>();
        Losses3 = GameObject.Find("Losses (3)").GetComponent<Text>();
        Draws3 = GameObject.Find("Draws (3)").GetComponent<Text>();
        Points3 = GameObject.Find("Points (3)").GetComponent<Text>();

        LeagueTeamList.Add(Team3);
        LeagueWinsList.Add(Wins3);
        LeagueLossesList.Add(Losses3);
        LeagueDrawsList.Add(Draws3);
        LeaguePointsList.Add(Points3);


        Team4 = GameObject.Find("Team (4)").GetComponent<Text>();
        Wins4 = GameObject.Find("Wins (4)").GetComponent<Text>();
        Losses4 = GameObject.Find("Losses (4)").GetComponent<Text>();
        Draws4 = GameObject.Find("Draws (4)").GetComponent<Text>();
        Points4 = GameObject.Find("Points (4)").GetComponent<Text>();

        LeagueTeamList.Add(Team4);
        LeagueWinsList.Add(Wins4);
        LeagueLossesList.Add(Losses4);
        LeagueDrawsList.Add(Draws4);
        LeaguePointsList.Add(Points4);

        Team5 = GameObject.Find("Team (5)").GetComponent<Text>();
        Wins5 = GameObject.Find("Wins (5)").GetComponent<Text>();
        Losses5 = GameObject.Find("Losses (5)").GetComponent<Text>();
        Draws5 = GameObject.Find("Draws (5)").GetComponent<Text>();
        Points5 = GameObject.Find("Points (5)").GetComponent<Text>();

        LeagueTeamList.Add(Team5);
        LeagueWinsList.Add(Wins5);
        LeagueLossesList.Add(Losses5);
        LeagueDrawsList.Add(Draws5);
        LeaguePointsList.Add(Points5);

        Team6 = GameObject.Find("Team (6)").GetComponent<Text>();
        Wins6 = GameObject.Find("Wins (6)").GetComponent<Text>();
        Losses6 = GameObject.Find("Losses (6)").GetComponent<Text>();
        Draws6 = GameObject.Find("Draws (6)").GetComponent<Text>();
        Points6 = GameObject.Find("Points (6)").GetComponent<Text>();

        LeagueTeamList.Add(Team6);
        LeagueWinsList.Add(Wins6);
        LeagueLossesList.Add(Losses6);
        LeagueDrawsList.Add(Draws6);
        LeaguePointsList.Add(Points6);

        Team7 = GameObject.Find("Team (7)").GetComponent<Text>();
        Wins7 = GameObject.Find("Wins (7)").GetComponent<Text>();
        Losses7 = GameObject.Find("Losses (7)").GetComponent<Text>();
        Draws7 = GameObject.Find("Draws (7)").GetComponent<Text>();
        Points7 = GameObject.Find("Points (7)").GetComponent<Text>();

        LeagueTeamList.Add(Team7);
        LeagueWinsList.Add(Wins7);
        LeagueLossesList.Add(Losses7);
        LeagueDrawsList.Add(Draws7);
        LeaguePointsList.Add(Points7);

        Team8 = GameObject.Find("Team (8)").GetComponent<Text>();
        Wins8 = GameObject.Find("Wins (8)").GetComponent<Text>();
        Losses8 = GameObject.Find("Losses (8)").GetComponent<Text>();
        Draws8 = GameObject.Find("Draws (8)").GetComponent<Text>();
        Points8 = GameObject.Find("Points (8)").GetComponent<Text>();

        LeagueTeamList.Add(Team8);
        LeagueWinsList.Add(Wins8);
        LeagueLossesList.Add(Losses8);
        LeagueDrawsList.Add(Draws8);
        LeaguePointsList.Add(Points8);

        Team9 = GameObject.Find("Team (9)").GetComponent<Text>();
        Wins9 = GameObject.Find("Wins (9)").GetComponent<Text>();
        Losses9 = GameObject.Find("Losses (9)").GetComponent<Text>();
        Draws9 = GameObject.Find("Draws (9)").GetComponent<Text>();
        Points9 = GameObject.Find("Points (9)").GetComponent<Text>();

        LeagueTeamList.Add(Team9);
        LeagueWinsList.Add(Wins9);
        LeagueLossesList.Add(Losses9);
        LeagueDrawsList.Add(Draws9);
        LeaguePointsList.Add(Points9);

        Team10 = GameObject.Find("Team (10)").GetComponent<Text>();
        Wins10 = GameObject.Find("Wins (10)").GetComponent<Text>();
        Losses10 = GameObject.Find("Losses (10)").GetComponent<Text>();
        Draws10 = GameObject.Find("Draws (10)").GetComponent<Text>();
        Points10 = GameObject.Find("Points (10)").GetComponent<Text>();

        LeagueTeamList.Add(Team10);
        LeagueWinsList.Add(Wins10);
        LeagueLossesList.Add(Losses10);
        LeagueDrawsList.Add(Draws10);
        LeaguePointsList.Add(Points10);


        Team11 = GameObject.Find("Team (11)").GetComponent<Text>();
        Wins11 = GameObject.Find("Wins (11)").GetComponent<Text>();
        Losses11 = GameObject.Find("Losses (11)").GetComponent<Text>();
        Draws11 = GameObject.Find("Draws (11)").GetComponent<Text>();
        Points11 = GameObject.Find("Points (11)").GetComponent<Text>();

        LeagueTeamList.Add(Team11);
        LeagueWinsList.Add(Wins11);
        LeagueLossesList.Add(Losses11);
        LeagueDrawsList.Add(Draws11);
        LeaguePointsList.Add(Points11);


        for (int i = 0; i <= 11; i++)
        {

            LeagueTeamList[i].text = teaminfo[SortedTeams[i].TeamID].Name;
            LeagueWinsList[i].text = SortedTeams[i].Wins.ToString();
            LeagueLossesList[i].text = SortedTeams[i].Losses.ToString();
            LeagueDrawsList[i].text = SortedTeams[i].Draws.ToString();
            LeaguePointsList[i].text = SortedTeams[i].Points.ToString();

        }


    }



    //Finding the index of the players team in the Sorted teams list and returning a table position.
    public string RetrievePos(int FindTeamID)
    {


        int i = SortedTeams.FindIndex(r => r.TeamID == FindTeamID);


        if (i == 0)
        {

            return "Table Position: 1st";


        }

        if (i == 1)
        {

            return "Table Position: 2nd";


        }

        if (i == 2)
        {

            return "Table Position: 3rd";


        }


        if (i == 3)
        {

            return "Table Position: 4th";


        }

        if (i == 4)
        {

            return "Table Position: 5th";


        }



        if (i == 5)
        {

            return "Table Position: 6th";


        }

        if (i == 6)
        {

            return "Table Position: 7th";


        }

        if (i == 7)
        {

            return "Table Position: 8th";


        }

        if (i == 8)
        {

            return "Table Position: 9th";


        }


        if (i == 9)
        {

            return "Table Position: 10th";


        }

        if (i == 10)
        {

            return "Table Position: 11th";


        }

        if (i == 11)
        {

            return "Table Position: 12th";


        }
        else
        {
            return null;

        }


    }



    // a win is worth 3 points and a draw is worth 1 point, so this is the basis of of how each teams numbers of points are calculated.
    //The teams are then sorted again by points once the point calculations are finished.
    public void PointsUpdater()
    {
        int WinsCounter = 0;


        // updates the points each team has based on wins and losses 
        for (int i = 0; i <= 11; i++)
        {
            WinsCounter = 0;

            WinsCounter = TableStats[i].Wins;
            WinsCounter = WinsCounter * 3;

            TableStats[i].Points = WinsCounter;


            TableStats[i].Points = TableStats[i].Points + TableStats[i].Draws;


        }

        //sorting the list
        SortedTeams = TableStats.OrderByDescending(x => x.Points).ToList();




    }




    //Iterating through the playerinfo list of classes and adding them to the SelectedSquad list if the Team ID matches TeamManagaedID.
    public void selectSquad()
    {
        SelectedSquad.Clear();
        for (int i = 0; i <= 275; i++)
        {
            if (playerinfo[i].TeamID == TeamManagedID)
            {

                SelectedSquad.Add(playerinfo[i]);



            }



        }


    }



    // Displaying the second page of the full squad. Seting the last uneeded text objects to false.
    public void NextSquadPage()
    {


        for (int i = 12; i <= 22; i++)
        {

            SquadNameList[i - 12].text = SelectedSquad[i].Name;
            SquadPositionList[i - 12].text = SelectedSquad[i].Position;
            SquadOverallList[i - 12].text = SelectedSquad[i].Overall.ToString();
            SquadAgeList[i - 12].text = SelectedSquad[i].Age.ToString();
            SquadFormList[i - 12].text = SelectedSquad[i].Form.ToString();
            SquadMoraleList[i - 12].text = SelectedSquad[i].Morale.ToString();

        }

        SquadNameList[11].gameObject.SetActive(false);
        SquadPositionList[11].gameObject.SetActive(false);
        SquadOverallList[11].gameObject.SetActive(false);
        SquadAgeList[11].gameObject.SetActive(false);
        SquadFormList[11].gameObject.SetActive(false);
        SquadMoraleList[11].gameObject.SetActive(false);

        TableCrash = true;
    }



    // Displaying the first page of the full squad, setting any previously inactive objects active.

    public void BackSquadPage()
    {
        if (TableCrash == true)
        {

            SquadNameList[11].gameObject.SetActive(true);
            SquadPositionList[11].gameObject.SetActive(true);
            SquadOverallList[11].gameObject.SetActive(true);
            SquadAgeList[11].gameObject.SetActive(true);
            SquadFormList[11].gameObject.SetActive(true);
            SquadMoraleList[11].gameObject.SetActive(true);




            for (int i = 0; i <= 11; i++)
            {

                SquadNameList[i].text = SelectedSquad[i].Name;
                SquadPositionList[i].text = SelectedSquad[i].Position;
                SquadOverallList[i].text = SelectedSquad[i].Overall.ToString();
                SquadAgeList[i].text = SelectedSquad[i].Age.ToString();
                SquadFormList[i].text = SelectedSquad[i].Form.ToString();
                SquadMoraleList[i].text = SelectedSquad[i].Morale.ToString();

                // Debug.Log(SelectedSquad[i].Name + " " + SelectedSquad[i].Position);

            }
            TableCrash = false;
        }

    }






    //Adding text objects to a list and iterating through a for loop to display them.

    public void populateSquad()
    {



        NextBtn = GameObject.Find("NextBtn").GetComponent<Button>();
        BackBtn = GameObject.Find("BackBtn").GetComponent<Button>();


        NameHeader = GameObject.Find("NameHeader").GetComponent<Text>();
        AgeHeader = GameObject.Find("AgeHeader").GetComponent<Text>();
        PositionHeader = GameObject.Find("PositionHeader").GetComponent<Text>();
        OverallHeader = GameObject.Find("OverallHeader").GetComponent<Text>();
        FormHeader = GameObject.Find("FormHeader").GetComponent<Text>();
        MoraleHeader = GameObject.Find("MoraleHeader").GetComponent<Text>();


        NameHeader1 = GameObject.Find("NameHeader (1)").GetComponent<Text>();
        AgeHeader1 = GameObject.Find("AgeHeader (1)").GetComponent<Text>();
        PositionHeader1 = GameObject.Find("PositionHeader (1)").GetComponent<Text>();
        OverallHeader1 = GameObject.Find("OverallHeader (1)").GetComponent<Text>();
        FormHeader1 = GameObject.Find("FormHeader (1)").GetComponent<Text>();
        MoraleHeader1 = GameObject.Find("MoraleHeader (1)").GetComponent<Text>();

        SquadNameList.Add(NameHeader1);
        SquadPositionList.Add(PositionHeader1);
        SquadOverallList.Add(OverallHeader1);
        SquadFormList.Add(FormHeader1);
        SquadMoraleList.Add(MoraleHeader1);
        SquadAgeList.Add(AgeHeader1);




        NameHeader2 = GameObject.Find("NameHeader (2)").GetComponent<Text>();
        AgeHeader2 = GameObject.Find("AgeHeader (2)").GetComponent<Text>();
        PositionHeader2 = GameObject.Find("PositionHeader (2)").GetComponent<Text>();
        OverallHeader2 = GameObject.Find("OverallHeader (2)").GetComponent<Text>();
        FormHeader2 = GameObject.Find("FormHeader (2)").GetComponent<Text>();
        MoraleHeader2 = GameObject.Find("MoraleHeader (2)").GetComponent<Text>();

        SquadNameList.Add(NameHeader2);
        SquadPositionList.Add(PositionHeader2);
        SquadOverallList.Add(OverallHeader2);
        SquadFormList.Add(FormHeader2);
        SquadMoraleList.Add(MoraleHeader2);
        SquadAgeList.Add(AgeHeader2);





        NameHeader3 = GameObject.Find("NameHeader (3)").GetComponent<Text>();
        AgeHeader3 = GameObject.Find("AgeHeader (3)").GetComponent<Text>();
        PositionHeader3 = GameObject.Find("PositionHeader (3)").GetComponent<Text>();
        OverallHeader3 = GameObject.Find("OverallHeader (3)").GetComponent<Text>();
        FormHeader3 = GameObject.Find("FormHeader (3)").GetComponent<Text>();
        MoraleHeader3 = GameObject.Find("MoraleHeader (3)").GetComponent<Text>();

        SquadNameList.Add(NameHeader3);
        SquadPositionList.Add(PositionHeader3);
        SquadOverallList.Add(OverallHeader3);
        SquadFormList.Add(FormHeader3);
        SquadMoraleList.Add(MoraleHeader3);
        SquadAgeList.Add(AgeHeader3);





        NameHeader4 = GameObject.Find("NameHeader (4)").GetComponent<Text>();
        AgeHeader4 = GameObject.Find("AgeHeader (4)").GetComponent<Text>();
        PositionHeader4 = GameObject.Find("PositionHeader (4)").GetComponent<Text>();
        OverallHeader4 = GameObject.Find("OverallHeader (4)").GetComponent<Text>();
        FormHeader4 = GameObject.Find("FormHeader (4)").GetComponent<Text>();
        MoraleHeader4 = GameObject.Find("MoraleHeader (4)").GetComponent<Text>();

        SquadNameList.Add(NameHeader4);
        SquadPositionList.Add(PositionHeader4);
        SquadOverallList.Add(OverallHeader4);
        SquadFormList.Add(FormHeader4);
        SquadMoraleList.Add(MoraleHeader4);
        SquadAgeList.Add(AgeHeader4);




        NameHeader5 = GameObject.Find("NameHeader (5)").GetComponent<Text>();
        AgeHeader5 = GameObject.Find("AgeHeader (5)").GetComponent<Text>();
        PositionHeader5 = GameObject.Find("PositionHeader (5)").GetComponent<Text>();
        OverallHeader5 = GameObject.Find("OverallHeader (5)").GetComponent<Text>();
        FormHeader5 = GameObject.Find("FormHeader (5)").GetComponent<Text>();
        MoraleHeader5 = GameObject.Find("MoraleHeader (5)").GetComponent<Text>();

        SquadNameList.Add(NameHeader5);
        SquadPositionList.Add(PositionHeader5);
        SquadOverallList.Add(OverallHeader5);
        SquadFormList.Add(FormHeader5);
        SquadMoraleList.Add(MoraleHeader5);
        SquadAgeList.Add(AgeHeader5);




        NameHeader6 = GameObject.Find("NameHeader (6)").GetComponent<Text>();
        AgeHeader6 = GameObject.Find("AgeHeader (6)").GetComponent<Text>();
        PositionHeader6 = GameObject.Find("PositionHeader (6)").GetComponent<Text>();
        OverallHeader6 = GameObject.Find("OverallHeader (6)").GetComponent<Text>();
        FormHeader6 = GameObject.Find("FormHeader (6)").GetComponent<Text>();
        MoraleHeader6 = GameObject.Find("MoraleHeader (6)").GetComponent<Text>();

        SquadNameList.Add(NameHeader6);
        SquadPositionList.Add(PositionHeader6);
        SquadOverallList.Add(OverallHeader6);
        SquadFormList.Add(FormHeader6);
        SquadMoraleList.Add(MoraleHeader6);
        SquadAgeList.Add(AgeHeader6);





        NameHeader7 = GameObject.Find("NameHeader (7)").GetComponent<Text>();
        AgeHeader7 = GameObject.Find("AgeHeader (7)").GetComponent<Text>();
        PositionHeader7 = GameObject.Find("PositionHeader (7)").GetComponent<Text>();
        OverallHeader7 = GameObject.Find("OverallHeader (7)").GetComponent<Text>();
        FormHeader7 = GameObject.Find("FormHeader (7)").GetComponent<Text>();
        MoraleHeader7 = GameObject.Find("MoraleHeader (7)").GetComponent<Text>();

        SquadNameList.Add(NameHeader7);
        SquadPositionList.Add(PositionHeader7);
        SquadOverallList.Add(OverallHeader7);
        SquadFormList.Add(FormHeader7);
        SquadMoraleList.Add(MoraleHeader7);
        SquadAgeList.Add(AgeHeader7);






        NameHeader8 = GameObject.Find("NameHeader (8)").GetComponent<Text>();
        AgeHeader8 = GameObject.Find("AgeHeader (8)").GetComponent<Text>();
        PositionHeader8 = GameObject.Find("PositionHeader (8)").GetComponent<Text>();
        OverallHeader8 = GameObject.Find("OverallHeader (8)").GetComponent<Text>();
        FormHeader8 = GameObject.Find("FormHeader (8)").GetComponent<Text>();
        MoraleHeader8 = GameObject.Find("MoraleHeader (8)").GetComponent<Text>();

        SquadNameList.Add(NameHeader8);
        SquadPositionList.Add(PositionHeader8);
        SquadOverallList.Add(OverallHeader8);
        SquadFormList.Add(FormHeader8);
        SquadMoraleList.Add(MoraleHeader8);
        SquadAgeList.Add(AgeHeader8);





        NameHeader9 = GameObject.Find("NameHeader (9)").GetComponent<Text>();
        AgeHeader9 = GameObject.Find("AgeHeader (9)").GetComponent<Text>();
        PositionHeader9 = GameObject.Find("PositionHeader (9)").GetComponent<Text>();
        OverallHeader9 = GameObject.Find("OverallHeader (9)").GetComponent<Text>();
        FormHeader9 = GameObject.Find("FormHeader (9)").GetComponent<Text>();
        MoraleHeader9 = GameObject.Find("MoraleHeader (9)").GetComponent<Text>();

        SquadNameList.Add(NameHeader9);
        SquadPositionList.Add(PositionHeader9);
        SquadOverallList.Add(OverallHeader9);
        SquadFormList.Add(FormHeader9);
        SquadMoraleList.Add(MoraleHeader9);
        SquadAgeList.Add(AgeHeader9);




        NameHeader10 = GameObject.Find("NameHeader (10)").GetComponent<Text>();
        AgeHeader10 = GameObject.Find("AgeHeader (10)").GetComponent<Text>();
        PositionHeader10 = GameObject.Find("PositionHeader (10)").GetComponent<Text>();
        OverallHeader10 = GameObject.Find("OverallHeader (10)").GetComponent<Text>();
        FormHeader10 = GameObject.Find("FormHeader (10)").GetComponent<Text>();
        MoraleHeader10 = GameObject.Find("MoraleHeader (10)").GetComponent<Text>();

        SquadNameList.Add(NameHeader10);
        SquadPositionList.Add(PositionHeader10);
        SquadOverallList.Add(OverallHeader10);
        SquadFormList.Add(FormHeader10);
        SquadMoraleList.Add(MoraleHeader10);
        SquadAgeList.Add(AgeHeader10);





        NameHeader11 = GameObject.Find("NameHeader (11)").GetComponent<Text>();
        AgeHeader11 = GameObject.Find("AgeHeader (11)").GetComponent<Text>();
        PositionHeader11 = GameObject.Find("PositionHeader (11)").GetComponent<Text>();
        OverallHeader11 = GameObject.Find("OverallHeader (11)").GetComponent<Text>();
        FormHeader11 = GameObject.Find("FormHeader (11)").GetComponent<Text>();
        MoraleHeader11 = GameObject.Find("MoraleHeader (11)").GetComponent<Text>();

        SquadNameList.Add(NameHeader11);
        SquadPositionList.Add(PositionHeader11);
        SquadOverallList.Add(OverallHeader11);
        SquadFormList.Add(FormHeader11);
        SquadMoraleList.Add(MoraleHeader11);
        SquadAgeList.Add(AgeHeader11);




        NameHeader12 = GameObject.Find("NameHeader (12)").GetComponent<Text>();
        AgeHeader12 = GameObject.Find("AgeHeader (12)").GetComponent<Text>();
        PositionHeader12 = GameObject.Find("PositionHeader (12)").GetComponent<Text>();
        OverallHeader12 = GameObject.Find("OverallHeader (12)").GetComponent<Text>();
        FormHeader12 = GameObject.Find("FormHeader (12)").GetComponent<Text>();
        MoraleHeader12 = GameObject.Find("MoraleHeader (12)").GetComponent<Text>();



        SquadNameList.Add(NameHeader12);
        SquadPositionList.Add(PositionHeader12);
        SquadOverallList.Add(OverallHeader12);
        SquadFormList.Add(FormHeader12);
        SquadMoraleList.Add(MoraleHeader12);
        SquadAgeList.Add(AgeHeader12);



        for (int i = 0; i <= 11; i++)
        {

            SquadNameList[i].text = SelectedSquad[i].Name;
            SquadPositionList[i].text = SelectedSquad[i].Position;
            SquadOverallList[i].text = SelectedSquad[i].Overall.ToString();
            SquadAgeList[i].text = SelectedSquad[i].Age.ToString();
            SquadFormList[i].text = SelectedSquad[i].Form.ToString();
            SquadMoraleList[i].text = SelectedSquad[i].Morale.ToString();



        }



    }



    //returns the opposition threat of the team with the same ID as TeamID to the view/controller.

    public int[] CalculateCurrentThreat(int TeamID)
    {

        int[] ToReturn = new int[2];



        ToReturn[0] = OppositionAttackThreat(SelectedSquad, TeamID);

        ToReturn[1] = OppositionDefenceThreat(SelectedSquad, TeamID);


        return ToReturn;



    }

   //returning faith stats to the view/controller/

    public int[] getFaith()
    {

        int[] ToReturn = new int[2];

        ToReturn[0] = teaminfo[TeamManagedID].BoardDiff;

        ToReturn[1] = teaminfo[TeamManagedID].FanDiff;

        return ToReturn;


    }

    public string[] getPlayerInfo()
    {

        string[] ToReturn = new string[3];

        ToReturn[0] = ManName;

        ToReturn[1] = ManStress.ToString();

        //Model returning an array with information to be passed to the view by the controller
        return ToReturn;


    }



    //used to find out the stats of every team in the game.

    public void OppositionTeamInfo()
    {

        List<PlayerInfo> TempSelectedSquad = new List<PlayerInfo>();

        for (int i = 0; i <= 11; i++)
        {
            TempSelectedSquad.Clear();

            for (int j = 0; j < playerinfo.Count; j++)
            {
                if (playerinfo[j].TeamID == i)
                {
                    TempSelectedSquad.Add(playerinfo[j]);


                }


            }


            teaminfo[i].Attack = OppositionAttackThreat(TempSelectedSquad, i);

            teaminfo[i].Defence = OppositionDefenceThreat(TempSelectedSquad, i);

            OppositionInfo t = new OppositionInfo();

            t.CounterCapability = returnCounterPlan(TempSelectedSquad, i);

            t.PressureCapability = returnPressurePlan(TempSelectedSquad, i);

            t.PossessionCapability = returnPossessionPlan(TempSelectedSquad, i);

            t.TeamID = i;

            oppinfo.Add(t);
            //  Debug.Log(oppinfo[i].CounterCapability + " " + oppinfo[i].PossessionCapability + " " + oppinfo[i].PressureCapability);

        }




    }

    //Looping through the passed in list of classes and calculating an attacking threat number, taking into account the stats for each individual class in the list.
    public int OppositionAttackThreat(List<PlayerInfo> OppThreat, int teamid)
    {

        int attacktotal = 0;
        int attackcounter = 0;
        CurrentTeamThreat = 0;
        CurrentTeamDefence = 0;
        List<int> AttackAverage = new List<int>();




        //CurrentTeamOverall
        for (int i = 0; i < OppThreat.Count(); i++)
        {
            if (OppThreat[i].Position == "ST")
            {
                attacktotal = 0;
                attacktotal = attacktotal + OppThreat[i].Shooting;
                attacktotal = attacktotal + OppThreat[i].Dribbling;
                attacktotal = attacktotal + OppThreat[i].Passing;

                AttackAverage.Add(attacktotal / 3);


            }

            if (OppThreat[i].Position == "LM")
            {
                attacktotal = 0;
                attacktotal = attacktotal + OppThreat[i].Shooting;
                attacktotal = attacktotal + OppThreat[i].Dribbling;
                attacktotal = attacktotal + OppThreat[i].Passing;
                AttackAverage.Add(attacktotal / 3);

            }


            if (OppThreat[i].Position == "RM")
            {
                attacktotal = 0;
                attacktotal = attacktotal + OppThreat[i].Shooting;
                attacktotal = attacktotal + OppThreat[i].Dribbling;
                attacktotal = attacktotal + OppThreat[i].Passing;
                AttackAverage.Add(attacktotal / 3);

            }

            if (OppThreat[i].Position == "CAM")
            {
                attacktotal = 0;
                attacktotal = attacktotal + OppThreat[i].Shooting;
                attacktotal = attacktotal + OppThreat[i].Dribbling;
                attacktotal = attacktotal + OppThreat[i].Passing;
                AttackAverage.Add(attacktotal / 3);

            }

            if (OppThreat[i].Position == "CM")
            {
                attacktotal = 0;
                attacktotal = attacktotal + OppThreat[i].Shooting;
                attacktotal = attacktotal + OppThreat[i].Dribbling;
                attacktotal = attacktotal + OppThreat[i].Passing;
                AttackAverage.Add(attacktotal / 3);

            }
        }





        for (int i = 0; i < AttackAverage.Count(); i++)
        {
            attackcounter = attackcounter + AttackAverage[i];

        }

        CurrentTeamThreat = attackcounter / AttackAverage.Count();

        return CurrentTeamThreat;





    }

    //Looping through the passed in list of classes and calculating an defencive threat number, taking into account the stats for each individual class in the list.


    public int OppositionDefenceThreat(List<PlayerInfo> OppThreat, int teamid)
    {


        int DefenceTotal = 0;
        int Defencecounter = 0;

        List<int> DefenceAverage = new List<int>();
        for (int i = 0; i < OppThreat.Count(); i++)
        {
            if (OppThreat[i].Position == "CB")
            {
                DefenceTotal = 0;
                DefenceTotal = DefenceTotal + OppThreat[i].Tackling;
                DefenceTotal = DefenceTotal + OppThreat[i].Physical;
                DefenceAverage.Add(DefenceTotal / 2);

            }


            if (OppThreat[i].Position == "RB")
            {
                DefenceTotal = 0;
                DefenceTotal = DefenceTotal + OppThreat[i].Tackling;
                DefenceTotal = DefenceTotal + OppThreat[i].Physical;
                DefenceAverage.Add(DefenceTotal / 2);

            }

            if (OppThreat[i].Position == "LB")
            {
                DefenceTotal = 0;
                DefenceTotal = DefenceTotal + OppThreat[i].Tackling;
                DefenceTotal = DefenceTotal + OppThreat[i].Physical;
                DefenceAverage.Add(DefenceTotal / 2);

            }

            if (OppThreat[i].Position == "CDM")
            {
                DefenceTotal = 0;
                DefenceTotal = DefenceTotal + OppThreat[i].Tackling;
                DefenceTotal = DefenceTotal + OppThreat[i].Physical;
                DefenceAverage.Add(DefenceTotal / 2);

            }

            if (OppThreat[i].Position == "GK")
            {
                DefenceTotal = 0;
                DefenceTotal = DefenceTotal + OppThreat[i].GKDistribution;
                DefenceTotal = DefenceTotal + OppThreat[i].GKReactions;
                DefenceAverage.Add(DefenceTotal / 2);

            }

        }


        for (int i = 0; i < DefenceAverage.Count(); i++)
        {
            Defencecounter = Defencecounter + DefenceAverage[i];

        }

        CurrentTeamDefence = Defencecounter / DefenceAverage.Count();

        return CurrentTeamDefence;


    }


   
    //Setting the ID of the teams to play each other based on the Game week.
    public void AwayFixtures(int GameWeek)
    {

        if (GameWeek == 1)
        {


            HomeTeams[0] = 4;
            HomeTeams[1] = 9;
            HomeTeams[2] = 10;
            HomeTeams[3] = 7;
            HomeTeams[4] = 8;
            HomeTeams[5] = 12;

            AwayTeams[0] = 11;
            AwayTeams[1] = 3;
            AwayTeams[2] = 6;
            AwayTeams[3] = 1;
            AwayTeams[4] = 5;
            AwayTeams[5] = 2;

            for (int i = 0; i <= 5; i++)
            {
                AwayTeams[i] = AwayTeams[i] - 1;
                HomeTeams[i] = HomeTeams[i] - 1;
            }



        }

        if (GameWeek == 2)
        {

            HomeTeams[0] = 4;
            HomeTeams[1] = 1;
            HomeTeams[2] = 6;
            HomeTeams[3] = 3;
            HomeTeams[4] = 11;
            HomeTeams[5] = 9;

            AwayTeams[0] = 5;
            AwayTeams[1] = 2;
            AwayTeams[2] = 12;
            AwayTeams[3] = 8;
            AwayTeams[4] = 7;
            AwayTeams[5] = 10;

            for (int i = 0; i <= 5; i++)
            {
                AwayTeams[i] = AwayTeams[i] - 1;
                HomeTeams[i] = HomeTeams[i] - 1;

            }


        }

        if (GameWeek == 3)
        {


            HomeTeams[0] = 4;
            HomeTeams[1] = 5;
            HomeTeams[2] = 1;
            HomeTeams[3] = 6;
            HomeTeams[4] = 3;
            HomeTeams[5] = 11;

            AwayTeams[0] = 2;
            AwayTeams[1] = 12;
            AwayTeams[2] = 8;
            AwayTeams[3] = 7;
            AwayTeams[4] = 10;
            AwayTeams[5] = 9;


            for (int i = 0; i <= 5; i++)
            {
                AwayTeams[i] = AwayTeams[i] - 1;
                HomeTeams[i] = HomeTeams[i] - 1;

            }


        }

        if (GameWeek == 4)
        {


            HomeTeams[0] = 4;
            HomeTeams[1] = 3;
            HomeTeams[2] = 11;
            HomeTeams[3] = 9;
            HomeTeams[4] = 10;
            HomeTeams[5] = 7;

            AwayTeams[0] = 6;
            AwayTeams[1] = 1;
            AwayTeams[2] = 5;
            AwayTeams[3] = 2;
            AwayTeams[4] = 12;
            AwayTeams[5] = 8;


            for (int i = 0; i <= 5; i++)
            {
                AwayTeams[i] = AwayTeams[i] - 1;
                HomeTeams[i] = HomeTeams[i] - 1;
            }


        }



        if (GameWeek == 5)
        {


            HomeTeams[0] = 4;
            HomeTeams[1] = 7;
            HomeTeams[2] = 8;
            HomeTeams[3] = 12;
            HomeTeams[4] = 2;
            HomeTeams[5] = 5;

            AwayTeams[0] = 10;
            AwayTeams[1] = 9;
            AwayTeams[2] = 11;
            AwayTeams[3] = 3;
            AwayTeams[4] = 6;
            AwayTeams[5] = 1;


            for (int i = 0; i <= 5; i++)
            {
                AwayTeams[i] = AwayTeams[i] - 1;
                HomeTeams[i] = HomeTeams[i] - 1;
            }



        }


        if (GameWeek == 6)
        {


            HomeTeams[0] = 4;
            HomeTeams[1] = 8;
            HomeTeams[2] = 12;
            HomeTeams[3] = 2;
            HomeTeams[4] = 5;
            HomeTeams[5] = 1;

            AwayTeams[0] = 7;
            AwayTeams[1] = 10;
            AwayTeams[2] = 9;
            AwayTeams[3] = 11;
            AwayTeams[4] = 3;
            AwayTeams[5] = 6;

            for (int i = 0; i <= 5; i++)
            {
                AwayTeams[i] = AwayTeams[i] - 1;
                HomeTeams[i] = HomeTeams[i] - 1;

            }

        }

        if (GameWeek == 7)
        {


            HomeTeams[0] = 4;
            HomeTeams[1] = 10;
            HomeTeams[2] = 7;
            HomeTeams[3] = 8;
            HomeTeams[4] = 12;
            HomeTeams[5] = 2;

            AwayTeams[0] = 9;
            AwayTeams[1] = 11;
            AwayTeams[2] = 3;
            AwayTeams[3] = 6;
            AwayTeams[4] = 1;
            AwayTeams[5] = 5;

            for (int i = 0; i <= 5; i++)
            {
                AwayTeams[i] = AwayTeams[i] - 1;
                HomeTeams[i] = HomeTeams[i] - 1;
            }



        }

        if (GameWeek == 8)
        {

            HomeTeams[0] = 4;
            HomeTeams[1] = 12;
            HomeTeams[2] = 2;
            HomeTeams[3] = 5;
            HomeTeams[4] = 1;
            HomeTeams[5] = 6;

            AwayTeams[0] = 8;
            AwayTeams[1] = 7;
            AwayTeams[2] = 10;
            AwayTeams[3] = 9;
            AwayTeams[4] = 11;
            AwayTeams[5] = 3;

            for (int i = 0; i <= 5; i++)
            {
                AwayTeams[i] = AwayTeams[i] - 1;
                HomeTeams[i] = HomeTeams[i] - 1;
            }


        }

        if (GameWeek == 9)
        {


            HomeTeams[0] = 4;
            HomeTeams[1] = 6;
            HomeTeams[2] = 3;
            HomeTeams[3] = 11;
            HomeTeams[4] = 9;
            HomeTeams[5] = 10;

            AwayTeams[0] = 1;
            AwayTeams[1] = 5;
            AwayTeams[2] = 2;
            AwayTeams[3] = 12;
            AwayTeams[4] = 8;
            AwayTeams[5] = 7;

            for (int i = 0; i <= 5; i++)
            {
                AwayTeams[i] = AwayTeams[i] - 1;
                HomeTeams[i] = HomeTeams[i] - 1;
            }




        }

        if (GameWeek == 10)
        {


            HomeTeams[0] = 4;
            HomeTeams[1] = 2;
            HomeTeams[2] = 5;
            HomeTeams[3] = 1;
            HomeTeams[4] = 6;
            HomeTeams[5] = 3;

            AwayTeams[0] = 12;
            AwayTeams[1] = 8;
            AwayTeams[2] = 7;
            AwayTeams[3] = 10;
            AwayTeams[4] = 9;
            AwayTeams[5] = 11;


            for (int i = 0; i <= 5; i++)
            {
                AwayTeams[i] = AwayTeams[i] - 1;
                HomeTeams[i] = HomeTeams[i] - 1;
            }

        }



        if (GameWeek == 11)
        {


            HomeTeams[0] = 4;
            HomeTeams[1] = 11;
            HomeTeams[2] = 9;
            HomeTeams[3] = 10;
            HomeTeams[4] = 7;
            HomeTeams[5] = 8;

            AwayTeams[0] = 3;
            AwayTeams[1] = 6;
            AwayTeams[2] = 1;
            AwayTeams[3] = 5;
            AwayTeams[4] = 2;
            AwayTeams[5] = 12;

            for (int i = 0; i <= 5; i++)
            {
                AwayTeams[i] = AwayTeams[i] - 1;
                HomeTeams[i] = HomeTeams[i] - 1;
            }

        }

        if (GameWeek == 12)
        {


            HomeTeams[0] = 12;
            HomeTeams[1] = 8;
            HomeTeams[2] = 7;
            HomeTeams[3] = 10;
            HomeTeams[4] = 9;
            HomeTeams[5] = 11;

            AwayTeams[0] = 4;
            AwayTeams[1] = 2;
            AwayTeams[2] = 5;
            AwayTeams[3] = 1;
            AwayTeams[4] = 6;
            AwayTeams[5] = 3;

            for (int i = 0; i <= 5; i++)
            {
                AwayTeams[i] = AwayTeams[i] - 1;
                HomeTeams[i] = HomeTeams[i] - 1;
            }

        }

        if (GameWeek == 13)
        {

            HomeTeams[0] = 3;
            HomeTeams[1] = 6;
            HomeTeams[2] = 1;
            HomeTeams[3] = 5;
            HomeTeams[4] = 2;
            HomeTeams[5] = 12;

            AwayTeams[0] = 4;
            AwayTeams[1] = 11;
            AwayTeams[2] = 9;
            AwayTeams[3] = 10;
            AwayTeams[4] = 7;
            AwayTeams[5] = 8;

            for (int i = 0; i <= 5; i++)
            {
                AwayTeams[i] = AwayTeams[i] - 1;
                HomeTeams[i] = HomeTeams[i] - 1;
            }



        }

        if (GameWeek == 14)
        {


            HomeTeams[0] = 6;
            HomeTeams[1] = 1;
            HomeTeams[2] = 5;
            HomeTeams[3] = 2;
            HomeTeams[4] = 12;
            HomeTeams[5] = 8;

            AwayTeams[0] = 4;
            AwayTeams[1] = 3;
            AwayTeams[2] = 11;
            AwayTeams[3] = 9;
            AwayTeams[4] = 10;
            AwayTeams[5] = 7;

            for (int i = 0; i <= 5; i++)
            {
                AwayTeams[i] = AwayTeams[i] - 1;
                HomeTeams[i] = HomeTeams[i] - 1;
            }



        }

        if (GameWeek == 15)
        {


            HomeTeams[0] = 5;
            HomeTeams[1] = 2;
            HomeTeams[2] = 12;
            HomeTeams[3] = 8;
            HomeTeams[4] = 7;
            HomeTeams[5] = 10;

            AwayTeams[0] = 4;
            AwayTeams[1] = 1;
            AwayTeams[2] = 6;
            AwayTeams[3] = 3;
            AwayTeams[4] = 11;
            AwayTeams[5] = 9;

            for (int i = 0; i <= 5; i++)
            {
                AwayTeams[i] = AwayTeams[i] - 1;
                HomeTeams[i] = HomeTeams[i] - 1;
            }


        }



        if (GameWeek == 16)
        {


            HomeTeams[0] = 11;
            HomeTeams[1] = 3;
            HomeTeams[2] = 6;
            HomeTeams[3] = 1;
            HomeTeams[4] = 5;
            HomeTeams[5] = 2;

            AwayTeams[0] = 4;
            AwayTeams[1] = 9;
            AwayTeams[2] = 10;
            AwayTeams[3] = 7;
            AwayTeams[4] = 8;
            AwayTeams[5] = 12;

            for (int i = 0; i <= 5; i++)
            {
                AwayTeams[i] = AwayTeams[i] - 1;
                HomeTeams[i] = HomeTeams[i] - 1;
            }



        }


        if (GameWeek == 17)
        {


            HomeTeams[0] = 9;
            HomeTeams[1] = 11;
            HomeTeams[2] = 3;
            HomeTeams[3] = 6;
            HomeTeams[4] = 1;
            HomeTeams[5] = 5;

            AwayTeams[0] = 4;
            AwayTeams[1] = 10;
            AwayTeams[2] = 7;
            AwayTeams[3] = 8;
            AwayTeams[4] = 12;
            AwayTeams[5] = 2;

            for (int i = 0; i <= 5; i++)
            {
                AwayTeams[i] = AwayTeams[i] - 1;
                HomeTeams[i] = HomeTeams[i] - 1;
            }


        }

        if (GameWeek == 18)
        {


            HomeTeams[0] = 10;
            HomeTeams[1] = 9;
            HomeTeams[2] = 11;
            HomeTeams[3] = 3;
            HomeTeams[4] = 6;
            HomeTeams[5] = 1;

            AwayTeams[0] = 4;
            AwayTeams[1] = 7;
            AwayTeams[2] = 8;
            AwayTeams[3] = 12;
            AwayTeams[4] = 2;
            AwayTeams[5] = 5;

            for (int i = 0; i <= 5; i++)
            {
                AwayTeams[i] = AwayTeams[i] - 1;
                HomeTeams[i] = HomeTeams[i] - 1;
            }



        }

        if (GameWeek == 19)
        {

            HomeTeams[0] = 7;
            HomeTeams[1] = 10;
            HomeTeams[2] = 9;
            HomeTeams[3] = 11;
            HomeTeams[4] = 3;
            HomeTeams[5] = 6;

            AwayTeams[0] = 4;
            AwayTeams[1] = 8;
            AwayTeams[2] = 12;
            AwayTeams[3] = 2;
            AwayTeams[4] = 5;
            AwayTeams[5] = 1;

            for (int i = 0; i <= 5; i++)
            {
                AwayTeams[i] = AwayTeams[i] - 1;
                HomeTeams[i] = HomeTeams[i] - 1;
            }


        }

        if (GameWeek == 20)
        {


            HomeTeams[0] = 1;
            HomeTeams[1] = 5;
            HomeTeams[2] = 2;
            HomeTeams[3] = 12;
            HomeTeams[4] = 8;
            HomeTeams[5] = 7;

            AwayTeams[0] = 4;
            AwayTeams[1] = 6;
            AwayTeams[2] = 3;
            AwayTeams[3] = 11;
            AwayTeams[4] = 9;
            AwayTeams[5] = 10;

            for (int i = 0; i <= 5; i++)
            {
                AwayTeams[i] = AwayTeams[i] - 1;
                HomeTeams[i] = HomeTeams[i] - 1;
            }



        }

        if (GameWeek == 21)
        {


            HomeTeams[0] = 8;
            HomeTeams[1] = 7;
            HomeTeams[2] = 10;
            HomeTeams[3] = 9;
            HomeTeams[4] = 11;
            HomeTeams[5] = 3;

            AwayTeams[0] = 4;
            AwayTeams[1] = 12;
            AwayTeams[2] = 2;
            AwayTeams[3] = 5;
            AwayTeams[4] = 1;
            AwayTeams[5] = 6;

            for (int i = 0; i <= 5; i++)
            {
                AwayTeams[i] = AwayTeams[i] - 1;
                HomeTeams[i] = HomeTeams[i] - 1;
            }

        }



        if (GameWeek == 22)
        {


            HomeTeams[0] = 2;
            HomeTeams[1] = 12;
            HomeTeams[2] = 8;
            HomeTeams[3] = 7;
            HomeTeams[4] = 10;
            HomeTeams[5] = 9;

            AwayTeams[0] = 4;
            AwayTeams[1] = 5;
            AwayTeams[2] = 1;
            AwayTeams[3] = 6;
            AwayTeams[4] = 3;
            AwayTeams[5] = 11;

            for (int i = 0; i <= 5; i++)
            {
                AwayTeams[i] = AwayTeams[i] - 1;
                HomeTeams[i] = HomeTeams[i] - 1;
            }



        }





    }


    //Initialising the machday info for every match to be played based on gameweek.
    public List<MatchDayInfo> ScheduleMatches(List<MatchDayInfo> MatchStats)
    {


        MatchStats.Clear();

        for (int i = 0; i <= 5; i++)
        {
            MatchDayInfo t = new MatchDayInfo();

            t.HomeID = HomeTeams[i];
            t.AwayID = AwayTeams[i];
            t.HomeGoals = 0;
            t.AwayGoals = 0;
            t.HomeYellows = 0;
            t.AwayYellows = 0;
            t.HomeReds = 0;
            t.AwayReds = 0;
            t.HomeFouls = 0;
            t.AwayFouls = 0;
            t.HomeScorers = "";
            t.AwayScorers = "";

            MatchStats.Add(t);

        }
        return MatchStats;



    }







    //Running the functions needed to complete a match day then updating the points of each team.
    public void Matchday(int Week)
    {
        Debug.Log("GameWeek: " + Week);
        MatchStats = MatchResults(MatchStats);
        PointsUpdater();
    }



    //Finding the match that the players team was involved in and then preparing the matchh information to be returned to ViewController.
    public string[] DisplayResult(int week)
    {

        string[] ToBeReturned = new string[5];



        int playerTrack = 0;
        for (int i = 0; i <= 5; i++)
        {

            if (MatchStats[i].AwayID == TeamManagedID)
            {

                playerTrack = i;

            }

            if (MatchStats[i].HomeID == TeamManagedID)
            {

                playerTrack = i;

            }


        }

        ToBeReturned[0] = (teaminfo[MatchStats[playerTrack].HomeID].Name + "  " + MatchStats[playerTrack].HomeGoals + " VS " + teaminfo[MatchStats[playerTrack].AwayID].Name + "  " + MatchStats[playerTrack].AwayGoals);
        ToBeReturned[1] = ("Match Week: " + week);

        ToBeReturned[2] = ("Home Fouls: " + MatchStats[playerTrack].HomeFouls +"\n " + " Away Fouls: " + MatchStats[playerTrack].AwayFouls);

        ToBeReturned[3] = ("Home Scorers: " + MatchStats[playerTrack].HomeScorers +"\n " + " Away Scorers: " + MatchStats[playerTrack].AwayScorers);
        ToBeReturned[4] = ("Home Yellows: " + MatchStats[playerTrack].HomeYellows + " Home Reds: " + MatchStats[playerTrack].HomeReds + "\n " + " Away Yellows: " + MatchStats[playerTrack].AwayYellows + " Away Reds: " + MatchStats[playerTrack].AwayReds);

        return ToBeReturned;
    }


    //Finding the opposition team on a set matchday for the player and finding any players with an overall of over 85 on that team and if the teams overall is better than the playes, this is all returned to View/Controller.

    public string[] MatchPreparation(List<MatchDayInfo> MatchInfo, int GameWeek)
    {
        string[] ToBeReturned = new string[3];
        string stars = "No notable stars.";

        List<string> oppStars = new List<string>();

        bool homeweak = false;
        bool awayweak = false;
        int playerTrack = 0;
        bool playerIsHome = false;
        for (int i = 0; i <= 5; i++)
        {
            if (MatchInfo[i].AwayID == TeamManagedID)
            {

                playerTrack = i;

            }

            if (MatchInfo[i].HomeID == TeamManagedID)
            {

                playerTrack = i;
                playerIsHome = true;
            }
        }





        int HomeTactic = 0;
        int AwayTactic = 0;
        //Firstly checking that each team will employ an appropiate gameplan against their opposition.





        int HomeBasicOverall = (teaminfo[MatchInfo[playerTrack].HomeID].Attack + teaminfo[MatchInfo[playerTrack].HomeID].Defence) / 2;
        int AwayBasicOverall = (teaminfo[MatchInfo[playerTrack].AwayID].Attack + teaminfo[MatchInfo[playerTrack].AwayID].Defence) / 2;


        //Significantly weaker teams will automatically opt for the counter option as catching the opposition on a break will be their best chance for success.
        //Slightly weaker teams should opt for pressure or counter depending on which they can execute better.
        int difference = HomeBasicOverall - AwayBasicOverall;

        if (difference > 4)
        {
            homeweak = true;

        }

        difference = AwayBasicOverall - HomeBasicOverall;

        if (difference < 4)
        {
            awayweak = false;
        }




        if (playerIsHome == true)
        {

            //finding opposition star player;
            for (int i = 0; i < playerinfo.Count(); i++)
            {

                if (playerinfo[i].TeamID == MatchInfo[playerTrack].AwayID && playerinfo[i].Star == 100)
                {

                    oppStars.Add(playerinfo[i].Name);

                }

            }

        }

        if (playerIsHome == false)
        {

            //finding opposition star player;
            for (int i = 0; i < playerinfo.Count(); i++)
            {

                if (playerinfo[i].TeamID == MatchInfo[playerTrack].HomeID && playerinfo[i].Star == 100)
                {

                    oppStars.Add(playerinfo[i].Name);

                }

            }

        }
        if (oppStars.Count() != 0)
        {
            stars = "";
            stars = oppStars.Aggregate((i, j) => i + ", " + j).ToString();
        }




        //Returning info about the opposing team.
        if (playerIsHome == true)
        {
            ToBeReturned[0] = (teaminfo[MatchInfo[playerTrack].AwayID].Name + " Scout Report");

            ToBeReturned[1] = "Opposition Attack: " + teaminfo[MatchInfo[playerTrack].AwayID].Attack + "  \n Our Attack: " + teaminfo[MatchInfo[playerTrack].HomeID].Attack + "  \n Star Players: " + stars;

            if (homeweak == true)
            {
                ToBeReturned[2] = " This team is significantly stronger than us all around so it is probably a good idea to field a defensive team and try to catch them on the counter.";

            }

            if (awayweak == true)
            {
                ToBeReturned[2] = " This team is weaker than us and we are clear favourites which means they are probably gonna play it safe and park the bus.";
            }

            if (difference < 4)
            {
                ToBeReturned[2] = "This is likely to be a very close game so it is a good idea to field our strongest team as this game could very well go either way. ";
            }

        }
        //Returning info about the opposing team.
        if (playerIsHome == false)
        {
            ToBeReturned[0] = (teaminfo[MatchInfo[playerTrack].HomeID].Name + " Scout Report");
            ToBeReturned[1] = "Opposition Attack: " + teaminfo[MatchInfo[playerTrack].HomeID].Attack + " \n Our Attack: " + teaminfo[MatchInfo[playerTrack].AwayID].Attack + "  \n Star Players: " + stars;

            if (awayweak == true)
            {
                ToBeReturned[2] = " This team is significantly stronger than us going forward so it is probably a good idea to field a defensive team and try to catch them on the counter.";

            }

            if (homeweak == true)
            {
                ToBeReturned[2] = " This team is weaker than us and we are clear favourites which means they are probably gonna play it safe and park the bus.";
            }

            if (difference < 4)
            {
                ToBeReturned[2] = "This is likely to be a very close game so it is a good idea to field our strongest team as this game could very well go either way. ";
            }

        }


        return ToBeReturned;


    }



    //Returns a true or false answer based on the players position in the table and the teams budget.
    public bool tryRaise()
    {
        int tableposition = SortedTeams.FindIndex(r => r.TeamID == TeamManagedID);
        Debug.Log(tableposition);

        if (teaminfo[TeamManagedID].Budget >= 700 && tableposition < 3)
        {
            ManStress = ManStress - 10;

            return true;

        }
        else if (teaminfo[TeamManagedID].Budget <= 600 && tableposition < 6)
        {
            ManStress = ManStress - 10;

            return true;

        }

        ManStress++;
        return false;

    }



    //Calculating the stats for each game.
    public List<MatchDayInfo> MatchResults(List<MatchDayInfo> MatchInfo)
    {

        int HomeTactic = 0;
        int AwayTactic = 0;


        //looping round for every match that is to be played on a specific match day.
        for (int i = 0; i <= 5; i++)
        {
            HomeTactic = 0;
            AwayTactic = 0;
            //Firstly checking that each team will employ an appropiate gameplan against their opposition.

           int HomeBasicOverall = (teaminfo[MatchInfo[i].HomeID].Attack + teaminfo[MatchInfo[i].HomeID].Defence) / 2;
           int AwayBasicOverall = (teaminfo[MatchInfo[i].AwayID].Attack + teaminfo[MatchInfo[i].AwayID].Defence) / 2;


            // weaker teams will automatically opt for the counter option as catching the opposition on a break will be their best chance for success.
            //weaker teams should opt for pressure or counter depending on which they can execute better.
            int difference = HomeBasicOverall - AwayBasicOverall;

            if (difference < 4)
            {
                AwayTactic = oppinfo[MatchInfo[i].AwayID].CounterCapability;

                HomeTactic = oppinfo[MatchInfo[i].HomeID].PossessionCapability;

            }

            difference = AwayBasicOverall - HomeBasicOverall;

            if (difference > 4)
            {

                HomeTactic = oppinfo[MatchInfo[i].HomeID].CounterCapability;
                AwayTactic = oppinfo[MatchInfo[i].AwayID].PossessionCapability;

            }

            //making sure the tactic capability of the player is the one that they selected rather than what the algorithm feels is appropiate
            if (MatchInfo[i].AwayID == TeamManagedID)
            {

                AwayTactic = SelectedTactic;

            }

            if (MatchInfo[i].HomeID == TeamManagedID)
            {


                HomeTactic = SelectedTactic;

            }


            //Dividing the tactic by 100 so that it can be multiplied with the amount of goals scored later on.
            decimal HomeExecution = (decimal)HomeTactic / 100;
            decimal AwayExecution = (decimal)AwayTactic / 100;



            //Dynamically prediciting the amount of goals that will be scored by each team on a specific match day. 


            // Based on the attacking capability of each team the amount of potential goals is calculated
            if (Enumerable.Range(0, 70).Contains(teaminfo[MatchInfo[i].HomeID].Attack))
            {
                MatchInfo[i].HomeGoals = MatchInfo[i].HomeGoals + RandomNumber(0, 2);

            }

            if (Enumerable.Range(71, 80).Contains(teaminfo[MatchInfo[i].HomeID].Attack))
            {
                MatchInfo[i].HomeGoals = MatchInfo[i].HomeGoals + RandomNumber(0, 3);

            }


            if (Enumerable.Range(81, 100).Contains(teaminfo[MatchInfo[i].HomeID].Attack))
            {
                MatchInfo[i].HomeGoals = MatchInfo[i].HomeGoals + RandomNumber(0, 4);

            }


            if (Enumerable.Range(0, 70).Contains(teaminfo[MatchInfo[i].AwayID].Attack))
            {
                MatchInfo[i].AwayGoals = MatchInfo[i].AwayGoals + RandomNumber(0, 2);

            }

            if (Enumerable.Range(71, 80).Contains(teaminfo[MatchInfo[i].AwayID].Attack))
            {
                MatchInfo[i].AwayGoals = MatchInfo[i].AwayGoals + RandomNumber(0, 3);

            }


            if (Enumerable.Range(81, 100).Contains(teaminfo[MatchInfo[i].AwayID].Attack))
            {
                MatchInfo[i].AwayGoals = MatchInfo[i].AwayGoals + RandomNumber(1, 4);

            }

            // Based on the defensive capability of each team the amount of potential goals conceded is calculated

            if (Enumerable.Range(0, 70).Contains(teaminfo[MatchInfo[i].AwayID].Defence))
            {
                MatchInfo[i].HomeGoals = MatchInfo[i].HomeGoals + RandomNumber(0, 3);

            }

            if (Enumerable.Range(71, 80).Contains(teaminfo[MatchInfo[i].AwayID].Defence))
            {
                MatchInfo[i].HomeGoals = MatchInfo[i].HomeGoals + RandomNumber(0, 2);

            }


            if (Enumerable.Range(81, 100).Contains(teaminfo[MatchInfo[i].AwayID].Defence))
            {
                MatchInfo[i].HomeGoals = MatchInfo[i].HomeGoals + RandomNumber(0, 1);

            }



            if (Enumerable.Range(0, 70).Contains(teaminfo[MatchInfo[i].HomeID].Defence))
            {
                MatchInfo[i].AwayGoals = MatchInfo[i].AwayGoals + RandomNumber(0, 3);

            }

            if (Enumerable.Range(71, 80).Contains(teaminfo[MatchInfo[i].HomeID].Defence))
            {
                MatchInfo[i].AwayGoals = MatchInfo[i].AwayGoals + RandomNumber(0, 2);

            }


            if (Enumerable.Range(81, 100).Contains(teaminfo[MatchInfo[i].HomeID].Defence))
            {
                MatchInfo[i].AwayGoals = MatchInfo[i].AwayGoals + RandomNumber(0, 1);

            }

            // How capable each team is capable of executing their gameplan is then factored in to make the scenario more realistc.


            MatchInfo[i].AwayGoals = Decimal.ToInt32(MatchInfo[i].AwayGoals * AwayExecution);
            MatchInfo[i].HomeGoals = Decimal.ToInt32(MatchInfo[i].HomeGoals * HomeExecution);




            // Dynamically choosing the scorers of each goal.

            List<PlayerInfo> likelyScorers = new List<PlayerInfo>();
            List<PlayerInfo> tempList = new List<PlayerInfo>();

            //Each players morale will play a big part in how often they score, followed by their shooting stats
            //Starting11.OrderBy(s => s.Morale);



            tempList = Starting11.OrderByDescending(s => s.Overall).ToList();
    


            if (TeamManagedID == MatchInfo[i].HomeID)
            {
                for (int j = 0; j < tempList.Count(); j++)
                {
                    Debug.Log(tempList[j].Name + " " + tempList[j].Overall);
                }


                for (int j = 0; j <= MatchInfo[i].HomeGoals ; j++)
                {


                    if (playerinfo[tempList[j].PlayerID - 1].Position != "GK" && playerinfo[tempList[j].PlayerID - 1].Position != "CB")
                    {
                        MatchInfo[i].HomeScorers += playerinfo[tempList[j].PlayerID - 1].Name + " " + RandomNumber(0, 90).ToString() + "', ";

                        Debug.Log(playerinfo[tempList[j].PlayerID - 1].Name + " " + playerinfo[tempList[j].PlayerID - 1].Goals + " Added");

                        playerinfo[tempList[j].PlayerID - 1].Goals++;
                        Debug.Log(playerinfo[tempList[j].PlayerID - 1].Name + " GOT THE GOAL");

                        Debug.Log(playerinfo[tempList[j].PlayerID - 1].Name);

                        playerinfo[tempList[j].PlayerID - 1].Form = playerinfo[tempList[j].PlayerID - 1].Form + RandomNumber(0, 5);
                    }
                }

                tempList.Clear();

                for (int j = 0; j <= 275; j++)
                {
                    if (playerinfo[j].TeamID == MatchInfo[i].AwayID && playerinfo[j].Position != "GK" && playerinfo[j].Position != "CB")
                    {

                        tempList.Add(playerinfo[j]);
                        // Debug.Log(playerinfo[j].Name);

                    }

                }



                tempList = tempList.OrderByDescending(s => s.Overall).ThenBy(s => s.Shooting).ThenBy(s => s.Form).ToList();



                for (int j = 0; j < MatchInfo[i].AwayGoals; j++)
                {

                    if (playerinfo[tempList[j].PlayerID].Position != "GK" && playerinfo[tempList[j].PlayerID].Position != "CB")
                    {
                        playerinfo[tempList[j].PlayerID].Goals++;
                        playerinfo[tempList[j].PlayerID].Form = playerinfo[tempList[j].PlayerID].Form + RandomNumber(0, 5);
                        MatchInfo[i].AwayScorers += playerinfo[tempList[j].PlayerID].Name + " " + RandomNumber(0, 90).ToString() + "', ";
                    }
                }





            }


            else if (TeamManagedID == MatchInfo[i].AwayID)
            {

                for (int j = 0; j < tempList.Count(); j++)
                {
                    Debug.Log(tempList[j].Name + " " + tempList[j].Overall);
                }


                for (int j = 0; j <= MatchInfo[i].AwayGoals; j++)
                {
                    if (playerinfo[tempList[j].PlayerID - 1].Position != "GK" && playerinfo[tempList[j].PlayerID - 1].Position != "CB")
                    {
                        Debug.Log(playerinfo[tempList[j].PlayerID - 1].Name + " " + playerinfo[tempList[j].PlayerID - 1].Overall + " Added");

                        playerinfo[tempList[j].PlayerID - 1].Goals++;
                        Debug.Log(playerinfo[tempList[j].PlayerID - 1].Name + " GOT THE GOAL");

                        playerinfo[tempList[j].PlayerID].Form = playerinfo[tempList[j].PlayerID - 1].Form + RandomNumber(0, 5);
                        MatchInfo[i].AwayScorers += playerinfo[tempList[j].PlayerID - 1].Name + " " + RandomNumber(0, 90).ToString() + "', ";

                    }
                
                 
                }

                tempList.Clear();

                for (int j = 0; j <= 275; j++)
                {
                    if (playerinfo[j].TeamID == MatchInfo[i].HomeID && playerinfo[j].Position != "GK" && playerinfo[j].Position != "CB")
                    {
                        tempList.Add(playerinfo[j]);
                    }
                }

                tempList = tempList.OrderByDescending(s => s.Overall).ThenBy(s => s.Shooting).ThenBy(s => s.Form).ToList();


  
                for (int j = 0; j < MatchInfo[i].HomeGoals; j++)
                {
                    if (playerinfo[tempList[j].PlayerID].Position != "GK" && playerinfo[tempList[j].PlayerID].Position != "CB")
                    {
                        playerinfo[tempList[j].PlayerID].Goals++;
                        playerinfo[tempList[j].PlayerID].Form = playerinfo[tempList[j].PlayerID].Form + RandomNumber(0, 5);

                        MatchInfo[i].HomeScorers += playerinfo[tempList[j].PlayerID].Name + " " + RandomNumber(0, 90).ToString() + "', ";
                    }

                }


            }

            else if (TeamManagedID == MatchInfo[i].AwayID && TeamManagedID == MatchInfo[i].HomeID)
            {
              

                for (int j = 0; j <= 275; j++)
                {
                    if (playerinfo[j].TeamID == MatchInfo[i].HomeID && playerinfo[j].Position != "GK" && playerinfo[j].Position != "CB")
                    {

                        tempList.Add(playerinfo[j]);

                    }

                }

               tempList = tempList.OrderByDescending(s => s.Overall).ThenBy(s => s.Shooting).ThenBy(s => s.Form).ToList();

                for (int j = 0; j <= MatchInfo[i].HomeGoals; j++)
                {
                    if (playerinfo[tempList[j].PlayerID].Position != "GK" && playerinfo[tempList[j].PlayerID].Position != "CB")
                    {
                        playerinfo[tempList[j].PlayerID].Goals++;
                        playerinfo[tempList[j].PlayerID].Form = playerinfo[tempList[j].PlayerID].Form + RandomNumber(0, 5);

                        MatchInfo[i].HomeScorers += playerinfo[tempList[j].PlayerID].Name + " " + RandomNumber(0, 90).ToString() + "', ";
                    }
            
                }


                tempList.Clear();


                //Now for the away team.

                for (int j = 0; j <= 275; j++)
                {
                    if (playerinfo[j].TeamID == MatchInfo[i].AwayID && playerinfo[j].Position != "GK" && playerinfo[j].Position != "CB")
                    {

                        tempList.Add(playerinfo[j]);

                    }

                }

                tempList = tempList.OrderByDescending(s => s.Star).ThenBy(s => s.Morale).ThenBy(s => s.Form).ToList();


                for (int j = 0; j <= MatchInfo[i].AwayGoals; j++)
                {
                    if (playerinfo[tempList[j].PlayerID].Position != "GK" && playerinfo[tempList[j].PlayerID].Position != "CB")
                    {
                        playerinfo[tempList[j].PlayerID].Goals++;
                        playerinfo[tempList[j].PlayerID].Form = playerinfo[tempList[j].PlayerID].Form + RandomNumber(0, 5);

                        MatchInfo[i].AwayScorers += playerinfo[tempList[j].PlayerID].Name + " " + RandomNumber(0, 90).ToString() + "', ";
                    }
                }


            }


            //Calculating the amount of fouls and bookings per game.


            //The overall agression of each team is what the foul count is based on.
            int awayFoulCounter = 0;
            for (int j = 0; j < playerinfo.Count(); j++)
            {

                if (playerinfo[j].TeamID == MatchInfo[i].AwayID)
                {
                   
                    awayFoulCounter = awayFoulCounter + playerinfo[j].Agression;

                }

            }
         
            awayFoulCounter = awayFoulCounter / 23;

            //The more aggressive a team is, the more fouls they will have.


            if (Enumerable.Range(0, 30).Contains(awayFoulCounter))
            {
                MatchInfo[i].AwayFouls = RandomNumber(0, 8);
                MatchInfo[i].AwayYellows = RandomNumber(0, 3);

            }

            if (Enumerable.Range(31, 50).Contains(awayFoulCounter))
            {
                MatchInfo[i].AwayFouls = RandomNumber(0, 10);
                MatchInfo[i].AwayYellows = RandomNumber(0, 4);

            }

            if (Enumerable.Range(51, 100).Contains(awayFoulCounter))
            {
                MatchInfo[i].AwayFouls = RandomNumber(0, 15);
                MatchInfo[i].AwayYellows = RandomNumber(0, 5);
                MatchInfo[i].AwayReds = RandomNumber(0, 1);
                //Making sure a red card has an affect on the game.
                if (MatchInfo[i].AwayReds == 1)
                {
                    MatchInfo[i].HomeGoals++;


                }

            }
         

            int HomeFoulCounter = 0;
            for (int j = 0; j < playerinfo.Count(); j++)
            {


                if (playerinfo[j].TeamID == MatchInfo[i].HomeID)
                {

                    HomeFoulCounter = HomeFoulCounter + playerinfo[j].Agression;

                }


            }

            HomeFoulCounter = HomeFoulCounter / 23;

            if (Enumerable.Range(0, 30).Contains(HomeFoulCounter))
            {
                MatchInfo[i].HomeFouls = RandomNumber(0, 8);
                MatchInfo[i].HomeYellows = RandomNumber(0, 3);

            }

            if (Enumerable.Range(31, 60).Contains(HomeFoulCounter))
            {
                MatchInfo[i].HomeFouls = RandomNumber(0, 10);
                MatchInfo[i].HomeYellows = RandomNumber(0, 4);

            }

            if (Enumerable.Range(61, 100).Contains(HomeFoulCounter))
            {
                MatchInfo[i].HomeFouls = RandomNumber(0, 15);
                MatchInfo[i].HomeYellows = RandomNumber(0, 5);
                MatchInfo[i].HomeReds = RandomNumber(0, 1);
                //Making sure a red card has an affect on the game.
                if (MatchInfo[i].HomeReds == 1)
                {
                    MatchInfo[i].AwayGoals++;


                }

            }











            //Applying the league stats

            teaminfo[MatchInfo[i].HomeID].Scored = teaminfo[MatchInfo[i].HomeID].Scored + MatchInfo[i].HomeGoals;
            teaminfo[MatchInfo[i].AwayID].Scored = teaminfo[MatchInfo[i].AwayID].Scored + MatchInfo[i].AwayGoals;

            // Adding Draws to each team


            if (MatchInfo[i].HomeGoals == MatchInfo[i].AwayGoals)
            {
                TableStats[MatchInfo[i].HomeID].Draws++;
                TableStats[MatchInfo[i].AwayID].Draws++;

            }

 
            //Adding a win to the winning team
            //And a loss to the losing side.
            if (MatchInfo[i].HomeGoals > MatchInfo[i].AwayGoals)
            {
                TableStats[MatchInfo[i].HomeID].Wins++;
                TableStats[MatchInfo[i].AwayID].Losses++;


                //Making sure the win has a positive affect on a team.
                //And a negative affect if the team lost.

                if (TeamManagedID == MatchInfo[i].AwayID)
                {

                    MatchDayEffects(false);

                }

                if (TeamManagedID == MatchInfo[i].HomeID)
                {
     
                    MatchDayEffects(true);
                }


            }

            //Making sure the win has a positive affect on a team.
            //And a negative affect if the team lost.

            if (MatchInfo[i].HomeGoals < MatchInfo[i].AwayGoals)
            {
                TableStats[MatchInfo[i].AwayID].Wins++;
                TableStats[MatchInfo[i].HomeID].Losses++;

                if (TeamManagedID == MatchInfo[i].HomeID)
                {

                    MatchDayEffects(false);
                }

                if (TeamManagedID == MatchInfo[i].AwayID)
                {

                    MatchDayEffects(true);
                }
            }


        }


        //Updating the amount of points for each team based on the now changed wins and losses.
        PointsUpdater();


        return MatchInfo;

    }

    //Making sure the win has a positive affect on a team.
    //And a negative affect if the team lost.

    public void MatchDayEffects(bool Win)
    {
      
        if (Win == false)
        {
            //A loss will result in every player that the user chose to start the game to have a reduced morale.
            //The manager will also gain some stress
            DecreaseFanFaith();
            DecreaseBoardFaith();
            ManStress = ManStress + 3;

            for (int i = 0; i < Starting11.Count(); i++)
            {
                playerinfo[Starting11[i].PlayerID].Morale = playerinfo[Starting11[i].PlayerID].Morale - 5;

            }
        }

        //A loss will result in every player that the user chose to start the game to have an improved morale.
        //The manager will also lose some stress

        if (Win == true)
        {
            IncreaseFanFaith();
            IncreaseBoardFaith();
            ManStress = ManStress - 3;

            for (int i = 0; i < Starting11.Count(); i++)
            {
                playerinfo[Starting11[i].PlayerID].Morale = playerinfo[Starting11[i].PlayerID].Morale + 5;

            }
        }
     

        //If a players morale is less than 50 their stats should detoriate by random amounts.

        for (int i = 0; i < Starting11.Count(); i++)
        {

            if (playerinfo[Starting11[i].PlayerID].Morale < 50)
            {

                playerinfo[Starting11[i].PlayerID].Passing = playerinfo[Starting11[i].PlayerID].Passing - RandomNumber(0,10);


                playerinfo[Starting11[i].PlayerID].Passing = playerinfo[Starting11[i].PlayerID].Shooting - RandomNumber(0, 10);

                playerinfo[Starting11[i].PlayerID].Passing = playerinfo[Starting11[i].PlayerID].Tackling - RandomNumber(0, 10);

                playerinfo[Starting11[i].PlayerID].Passing = playerinfo[Starting11[i].PlayerID].Dribbling - RandomNumber(0, 10);

            }


            //If a players morale is more than 60 then the players stats should improve by random amounts.
            if (playerinfo[Starting11[i].PlayerID].Morale > 60)
            {

                playerinfo[Starting11[i].PlayerID].Passing = playerinfo[Starting11[i].PlayerID].Passing + RandomNumber(0, 5);


                playerinfo[Starting11[i].PlayerID].Passing = playerinfo[Starting11[i].PlayerID].Shooting + RandomNumber(0, 5);

                playerinfo[Starting11[i].PlayerID].Passing = playerinfo[Starting11[i].PlayerID].Tackling + RandomNumber(0, 5);

                playerinfo[Starting11[i].PlayerID].Passing = playerinfo[Starting11[i].PlayerID].Dribbling + RandomNumber(0, 5);

            }

        }

        // The players overalls should be updated and 
        // the SelectedSquad list should be updated.
        updateOverall();
        selectSquad();

    }








    // Making sure each random number is actually random.

    public static int RandomNumber(int min, int max)
    {
        lock (syncLock)
        { 
            return UnityEngine.Random.Range(min, max);
        }
    }






    //Initialing the table information.

    public void initTableInfo()
    {
        TableStats.Clear();

        for (int i = 0; i <= 11; i++)
        {
            TableInfo t = new TableInfo();

            t.TeamID = i;
            t.Wins = 0;
            t.Losses = 0;
            t.Draws = 0;
            t.Scored = 0;
            t.Points = 0;


            TableStats.Add(t);
        }


    }



    //Returnig the scouting report information to the player.
    public string[] prepareTeams(int Week)
    {


        string[] ReturnThis = new string[3];
        OppositionTeamInfo();

        AwayFixtures(Week);


        MatchStats = ScheduleMatches(MatchStats);


        ReturnThis = MatchPreparation(MatchStats, Week);



        return ReturnThis;



    }


    // returning squad and manager status based on the average morale of the squad and the managers squad level.

    public string[] GetNotifications()
    {
        string[] ReturnThis = new string[3];

        int counter = 0;
        for (int i = 0; i < SelectedSquad.Count; i++)
        {
            counter = counter + SelectedSquad[i].Morale;
        }

        int SquadMorale = counter / 23;


        if (Enumerable.Range(70, 100).Contains(SquadMorale))
        {
            ReturnThis[0] = "The Squads overall morale is good and the players are improving well due to the good vibes";

        }

        if (Enumerable.Range(50, 69).Contains(SquadMorale))
        {
            ReturnThis[0] = "The Squads overall morale is acceptable but could be improved, there is currently no negative effects on the squads performance due to this";

        }

        if (Enumerable.Range(0, 49).Contains(SquadMorale))
        {
            ReturnThis[0] = "The Squads overall morale is not acceptable and must be improved, The team will get worse and worse if nothing is done about this";

        }




        string[] ManagerInfo = new string[2];

        ManagerInfo = managerDistractions(ManStress);

        if (ManagerInfo[1] == "0")
        {
            ReturnThis[1] = ManagerInfo[0];
            ReturnThis[2] = "This does not have any further impact on your stress level";
        
        }

        if (ManagerInfo[1] == "1")
        {
            ReturnThis[1] = ManagerInfo[0];
            ReturnThis[2] = "This has a further impact on you stress, Stress +5";
            ManStress = ManStress + 5;

        }




        return ReturnThis;


    }

    // returning a random situation which will randomly have a further affect on the players stress.

    public string[] managerDistractions(int Stress)
    {

        string[] ReturnThis = new string[2];

        string[] Situations = new string[6];

        Situations[0] = "Your wife has left you due to you being distant, she has taken the kids. This may impact your stress level even more";

        Situations[1] = "You have made a poor financial decision by buying a sports car you cannot afford, your wife is raging.";

        Situations[2] = "You have began chainsmoking to deal with the stress";

        Situations[3] = "You have began a massive losing streak on Fifa, sucks to be you";

        Situations[4] = "You have dropped your phone and smashed your screen, you are raging";


        Situations[5] = "You are feeling fine and your stress is at a managable but not an ideal level.";

        Situations[6] = "You are feeling great and decided to treat your family to a night at the cinema";

        Situations[7] = "You are feeling great and decided to treat your family to a day at the beach";



        if (Enumerable.Range(35, 55).Contains(Stress))
        {

            ReturnThis[0] = Situations[3];
            ReturnThis[1] = RandomNumber(0, 1).ToString();

        }

        if (Enumerable.Range(0, 34).Contains(Stress))
        {

            ReturnThis[0] = Situations[RandomNumber(6, 7)];
            ReturnThis[1] = RandomNumber(0, 1).ToString();


        }

        if (Enumerable.Range(56, 100).Contains(Stress))
        {

            ReturnThis[0] = Situations[RandomNumber(0, 4)];
            ReturnThis[1] = RandomNumber(0, 1).ToString();


        }



        return ReturnThis;

    }

    //Increasing and decreasing the faith levels by 5.

    public void IncreaseFanFaith()
    {

        teaminfo[TeamManagedID].FanDiff = teaminfo[TeamManagedID].FanDiff + 5;

    }

    public void DecreaseFanFaith()
    {

        teaminfo[TeamManagedID].FanDiff = teaminfo[TeamManagedID].FanDiff - 5;


    }

    public void DecreaseBoardFaith()
    {

        teaminfo[TeamManagedID].BoardDiff = teaminfo[TeamManagedID].BoardDiff - 5;


    }

    public void IncreaseBoardFaith()
    {
        teaminfo[TeamManagedID].BoardDiff = teaminfo[TeamManagedID].BoardDiff + 5;


    }



    //Selecting the 23 player squad for the player to use.
    public void InitPlayerTeam()
    {

        selectSquad();

    }

    public void InitModel()
    {

        // for test purposes pre chosen team.
        //TeamManagedID = 5;
        loadTeamData();
        loadPlayerData();
        updateOverall();
        OppositionTeamInfo();
        initTableInfo();
        PointsUpdater();


    }

    //calculating the overall for each player in playerinfo taking account each players position.

    public void updateOverall()
    {

        for (int i = 0; i <= 275; i++)
        {
            if (playerinfo[i].Position == "GK")
            {
                playerinfo[i].Overall = (playerinfo[i].GKDistribution + playerinfo[i].GKReactions + playerinfo[i].Physical) / 3;

            }
            else if (playerinfo[i].Position == "CM")
            {
                playerinfo[i].Overall = (playerinfo[i].Passing + playerinfo[i].Dribbling + playerinfo[i].Shooting + playerinfo[i].Tackling + playerinfo[i].Pace + playerinfo[i].Physical) / 6;

            }
            else if (playerinfo[i].Position == "CAM")
            {
                playerinfo[i].Overall = (playerinfo[i].Passing + playerinfo[i].Dribbling + playerinfo[i].Shooting + playerinfo[i].Pace + playerinfo[i].Physical) / 5;

            }
            else if (playerinfo[i].Position == "CDM")
            {
                playerinfo[i].Overall = (playerinfo[i].Passing + playerinfo[i].Dribbling + playerinfo[i].Tackling + playerinfo[i].Pace + playerinfo[i].Physical) / 5;

            }
            else if (playerinfo[i].Position == "LM")
            {
                playerinfo[i].Overall = (playerinfo[i].Passing + playerinfo[i].Dribbling + playerinfo[i].Shooting + playerinfo[i].Pace + playerinfo[i].Physical) / 5;

            }
            else if (playerinfo[i].Position == "RM")
            {
                playerinfo[i].Overall = (playerinfo[i].Passing + playerinfo[i].Dribbling + playerinfo[i].Shooting + playerinfo[i].Pace + playerinfo[i].Physical) / 5;

            }
            else if (playerinfo[i].Position == "LB")
            {
                playerinfo[i].Overall = (playerinfo[i].Passing + playerinfo[i].Dribbling + playerinfo[i].Tackling + playerinfo[i].Pace + playerinfo[i].Physical) / 5;

            }
            else if (playerinfo[i].Position == "RB")
            {
                playerinfo[i].Overall = (playerinfo[i].Passing + playerinfo[i].Dribbling + playerinfo[i].Tackling + playerinfo[i].Pace + playerinfo[i].Physical) / 5;

            }
            else if (playerinfo[i].Position == "CB")
            {
                playerinfo[i].Overall = (playerinfo[i].Passing + playerinfo[i].Tackling + playerinfo[i].Pace + playerinfo[i].Physical) / 4;

            }
            else if (playerinfo[i].Position == "ST")
            {
                playerinfo[i].Overall = (playerinfo[i].Dribbling + playerinfo[i].Passing + playerinfo[i].Shooting + playerinfo[i].Pace + playerinfo[i].Physical) / 5;

            }




        }



        for (int i = 0; i <= 275; i++)
        {

            if (playerinfo[i].Overall >= 85)
            {
                playerinfo[i].Star = 100;
                playerinfo[i].Confidence = 80;

            }

        }



    }

    //Returning the team information to the View/Controller for them to display to the user.

    public string[] changeTeam()
    {
        if (index < 11)
        {
            index++;
       
            return TeamSelect(index);
        }
        else
        {
            index = 0;
         
            return TeamSelect(index);
        }




    }

    //chooses a team for the player to use
    public void chooseTeam()
    {
        
        TeamManagedID = index;

    }

    //Triggered by changeTeam()
    public string[] TeamSelect(int index)
    {
        string[] ReturnThis = new string[5];

        ReturnThis[0] = ("Name: " + teaminfo[index].Name);
        ReturnThis[1] = ("Reputation: " + teaminfo[index].Rep);
        ReturnThis[2] = ("Budget: " + teaminfo[index].Budget);
        ReturnThis[3] = ("Attack/Defence: " + teaminfo[index].Attack + "/" + teaminfo[index].Defence);
        ReturnThis[4] = ("Ground: " + teaminfo[index].Ground);


        return ReturnThis;
    }


    // Reading in data from a csv file and placing it in a list.

    public void loadPlayerData()
    {

        PlayerData = Resources.Load<TextAsset>("PlayerDataPresets");



        string[] playerdata = PlayerData.text.Split(new char[] { '\n' });


        for (int i = 1; i < playerdata.Length; i++)
        {
            string[] row = playerdata[i].Split(new char[] { ',' });

            if (row[1] != "")
            {
                PlayerInfo t = new PlayerInfo();

                int.TryParse(row[0], out t.PlayerID);
                int.TryParse(row[1], out t.TeamID);
                t.Name = row[2];
                t.Nationality = row[3];
                int.TryParse(row[4], out t.Age);
                int.TryParse(row[5], out t.Overall);
                t.Position = row[6];
                int.TryParse(row[7], out t.Value);
                int.TryParse(row[8], out t.ContractLength);
                int.TryParse(row[9], out t.Dribbling);
                int.TryParse(row[10], out t.Passing);
                int.TryParse(row[11], out t.Tackling);
                int.TryParse(row[12], out t.Shooting);
                int.TryParse(row[13], out t.Pace);
                int.TryParse(row[14], out t.Physical);
                int.TryParse(row[15], out t.GKDistribution);
                int.TryParse(row[16], out t.GKReactions);
                int.TryParse(row[17], out t.MentalToughness);
                int.TryParse(row[18], out t.Agression);
                int.TryParse(row[19], out t.Confidence);
                int.TryParse(row[20], out t.Star);
                int.TryParse(row[21], out t.Happiness);
                int.TryParse(row[22], out t.Morale);
                int.TryParse(row[23], out t.Form);
                int.TryParse(row[24], out t.Goals);
                int.TryParse(row[25], out t.Assists);
                playerinfo.Add(t);
            }



        }
    }




    // Reading in data from a csv file and placing it in a list.
    public void loadTeamData()
    {

        TeamData = Resources.Load<TextAsset>("TeamData");



        string[] teamdata = TeamData.text.Split(new char[] { '\n' });


        for (int i = 1; i < teamdata.Length; i++)
        {
            string[] row = teamdata[i].Split(new char[] { ',' });

            if (row[1] != "")
            {
                TeamInfo t = new TeamInfo();

                int.TryParse(row[0], out t.ID);
                t.Name = row[1];
                int.TryParse(row[2], out t.Rep);
                int.TryParse(row[3], out t.Budget);
                int.TryParse(row[4], out t.Attack);
                int.TryParse(row[5], out t.Defence);
                t.Ground = row[6];
                int.TryParse(row[7], out t.Scored);
                int.TryParse(row[8], out t.Conceded);
                int.TryParse(row[9], out t.Wins);
                int.TryParse(row[10], out t.Losses);
                int.TryParse(row[11], out t.Draws);
                int.TryParse(row[12], out t.Points);
                int.TryParse(row[13], out t.BoardDiff);
                int.TryParse(row[14], out t.FanDiff);

                teaminfo.Add(t);
            }



        }




    }











}























































