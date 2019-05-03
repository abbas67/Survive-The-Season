using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;




public class UiManagement : MonoBehaviour
{

    public Text TeamOverallText;
    public Text TablePositionText;
    public Text AttackingThreatText;
    public Text DefensiveThreatText;
    public Text CurrentGameplanText;
    public Text GameplanCapabilityText;
    public Button PressureBtn;
    public Button CounterBtn;
    public Button PossesionBtn;








    public Button NextBtn;
    public Button BackBtn;

    public Text BoardText;
    public Text FanText;
    public Text ManagerText;

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


















    Team myteam = new Team();
    Player myplayer = new Player();
    TeamSetup myTeamSetup = new TeamSetup();

    List<Text> Tlist = new List<Text>();
    List<Text> SquadAgeList = new List<Text>();
    List<Text> SquadOverallList = new List<Text>();
    List<Text> SquadFormList = new List<Text>();
    List<Text> SquadMoraleList = new List<Text>();
    List<Text> SquadPositionList = new List<Text>();
    List<Text> SquadNameList = new List<Text>();

    List<Text> LeagueTeamList = new List<Text>();
    List<Text> LeagueWinsList = new List<Text>();
    List<Text> LeagueLossesList = new List<Text>();
    List<Text> LeagueDrawsList = new List<Text>();
    List<Text> LeaguePointsList = new List<Text>();

    public List<OppositionInfo> oppinfo = new List<OppositionInfo>();

    public List<PlayerInfo> SelectedSquad = new List<PlayerInfo>();

    public List<TableInfo> SortedTeams = new List<TableInfo>();

    public List<Text> SquadChoice;



    static public int CurrentTeamOverall;
    static public int CurrentTeamThreat;
    static public int CurrentTeamDefence;
    static public int CurrentTeamPossesion;
    static public int CurrentTeamCounter;
    static public int CurrentTeamPressure;



    public Text FinalScoreText;
    public Text ScorersText;
    public Text CardsText;
    public Text FoulsText;
    public Text GameDayText;


    public List<TableInfo> TableStats = new List<TableInfo>();

    public List<MatchDayInfo> MatchStats = new List<MatchDayInfo>();
    public int GameWeek = 1;

    int[] HomeTeams = new int[] { 0, 2, 4, 6, 8, 10 };
    int[] AwayTeams = new int[] { 1, 3, 5, 7, 9, 11 };

    private static readonly System.Random rnd = new System.Random();
    private static object syncLock = new object();

    public Text GameWeekTxt;
    public Text ManStressTxt;
    public Text ManNameTxt;








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
    public Text LineupText;

    public bool LMSelectCheck = false;

    public List<Starting11Info> Keepers = new List<Starting11Info>();
    public List<Starting11Info> CentreBacks = new List<Starting11Info>();
    List<Starting11Info> RightBacks = new List<Starting11Info>();
    List<Starting11Info> LeftBacks = new List<Starting11Info>();
    List<Starting11Info> MidFielders = new List<Starting11Info>();
    List<Starting11Info> LeftMid = new List<Starting11Info>();
    List<Starting11Info> RightMid = new List<Starting11Info>();
    List<Starting11Info> Striker = new List<Starting11Info>();

    public List<Starting11Info> SquadTracker = new List<Starting11Info>();


    public List<PlayerInfo> Starting11 = new List<PlayerInfo>();
    List<Button> GKTracker = new List<Button>();
    List<Button> RBTracker = new List<Button>();
    List<Button> LBTracker = new List<Button>();
    List<Button> CBTracker = new List<Button>();
    List<Button> RMTracker = new List<Button>();
    List<Button> LMTracker = new List<Button>();
    List<Button> STTracker = new List<Button>();
    List<Button> MFTracker = new List<Button>();
    public int totalST = 0;
    public int totalCB = 0;
    public int totalMF = 0;
    public int totalRB = 0;
    public int totalLB = 0;
    public int totalLM = 0;
    public int totalRM = 0;
    public int totalGK = 0;
    public int TotalStarters = 0;



    public bool STbtn1pressed = false;
    public bool MFbtn1pressed = false;
    public bool CBbtn1pressed = false;
    public bool RMbtn1pressed = false;
    public bool LMbtn1pressed = false;
    public bool RBbtn1pressed = false;
    public bool LBbtn1pressed = false;
    public bool GKbtn1pressed = false;

    public Text PlayerWarnings;

    public Text SquadCapabilitiesText;




    public void DisplayNewAttackDefence()
    {
        if (Starting11.Count >= 8)
        {
            SquadCapabilitiesText.text = "Attacking Threat: " + OppositionAttackThreat(Starting11, TeamSetup.TeamManagedID) + "    Defensive Threat: " + OppositionDefenceThreat(Starting11, TeamSetup.TeamManagedID);


        }



    }




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





    public void PlayerStarterView()
    {

        for (int i = 0; i < Starting11.Count(); i++)
        {

            LineupText.text = LineupText.text + Starting11[i].Name;

        }


    }






    public void SelectGK(int ButtonID)
    {
        if (ButtonID == 0 )
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

            Debug.Log("new list");
            for (int i = 0; i < Starting11.Count(); i++)
            {

                Debug.Log(Starting11[i].Name);

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


            Debug.Log("new list");
            for (int i = 0; i < Starting11.Count(); i++)
            {

                Debug.Log(Starting11[i].Name);

            }

        }






    }





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


            }

            Debug.Log("new list");
            for (int i = 0; i < Starting11.Count(); i++)
            {

                Debug.Log(Starting11[i].Name);

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


            }


            Debug.Log("new list");
            for (int i = 0; i < Starting11.Count(); i++)
            {
             
                Debug.Log(Starting11[i].Name);

            }
           
        }

    }

    public void SelectRM(int ButtonID)
    {

        PlayerWarnings.text = "Choose 11 players to start";

        if (ButtonID == 0)
        {

            if (totalRM != 1 && RightMid[ButtonID].Starting == false)
            {
                AddToLineup(RightMid[ButtonID].PlayerID);
                RMTracker[ButtonID].GetComponent<Image>().color = Color.grey;
                RightMid[ButtonID].Starting = true;

                totalRM++;
                RMbtn1pressed = true;
            }
            else
            if (RightMid[ButtonID].Starting == true && RMbtn1pressed == true)
            {
                RemoveFromLineup(RightMid[ButtonID].PlayerID);
                RMTracker[ButtonID].GetComponent<Image>().color = Color.white;
                RightMid[ButtonID].Starting = false;
                totalRM--;

            }
            else if (Starting11.Count == 11)
            {
                PlayerWarnings.text = ("You can only field a maximum of 11 players at a time");
                RemoveFromLineup(Striker[ButtonID].PlayerID);
                STTracker[ButtonID].GetComponent<Image>().color = Color.white;
                Striker[ButtonID].Starting = false;
                totalST--;
            }
            else
            {
                PlayerWarnings.text = ("You should only be playing 1 wide attacking player attacking player at a time on each side ");


            }

        }

        if (ButtonID == 1)
        {

            if (totalRM != 1 && RightMid[ButtonID].Starting == false)
            {
                AddToLineup(RightMid[ButtonID].PlayerID);
                RMTracker[ButtonID].GetComponent<Image>().color = Color.grey;
                RightMid[ButtonID].Starting = true;

                totalRM++;
                RMbtn1pressed = true;
            }
            else
            if (RightMid[ButtonID].Starting == true && RMbtn1pressed == true)
            {
                RemoveFromLineup(RightMid[ButtonID].PlayerID);
                RMTracker[ButtonID].GetComponent<Image>().color = Color.white;
                RightMid[ButtonID].Starting = false;
                totalRM--;

            }
            else if (Starting11.Count == 11)
            {
                PlayerWarnings.text = ("You can only field a maximum of 11 players at a time");
            }
            else
            {
                PlayerWarnings.text = ("You should only be playing 1 wide attacking player attacking player at a time on each side ");


            }

        }

        Debug.Log("new list");

            for (int i = 0; i < Starting11.Count(); i++)
            {
               
                Debug.Log(Starting11[i].Name);

            }





        Debug.Log(Starting11.Count());

        }
     
 





    public void SelectST(int ButtonID)
    {
        PlayerWarnings.text = "Choose 11 players to start";



        if (ButtonID == 0)
        {

                if (totalST != 2 && Striker[ButtonID].Starting == false)
                {
                    AddToLineup(Striker[ButtonID].PlayerID);
                    STTracker[ButtonID].GetComponent<Image>().color = Color.grey;
                    Striker[ButtonID].Starting = true;

                    totalST++;
                    STbtn1pressed = true;
                }
                else
                if (Striker[ButtonID].Starting == true && STbtn1pressed == true)
                {
                    RemoveFromLineup(Striker[ButtonID].PlayerID);
                    STTracker[ButtonID].GetComponent<Image>().color = Color.white;
                    Striker[ButtonID].Starting = false;
                    totalST--;

                }
            else if (Starting11.Count == 11)
            {
                PlayerWarnings.text = ("You can only field a maximum of 11 players at a time");
            }
            else
            {
                PlayerWarnings.text = ("You should only be playing a maximum of two strikers ");


            }

        }

        if (ButtonID == 1)
        {
            if (totalST != 2 && Striker[ButtonID].Starting == false)
            {
                AddToLineup(Striker[ButtonID].PlayerID);
                STTracker[ButtonID].GetComponent<Image>().color = Color.grey;
                Striker[ButtonID].Starting = true;

                totalST++;
                STbtn1pressed = true;
            }
            else
            if (Striker[ButtonID].Starting == true && STbtn1pressed == true)
            {
                RemoveFromLineup(Striker[ButtonID].PlayerID);
                STTracker[ButtonID].GetComponent<Image>().color = Color.white;
                Striker[ButtonID].Starting = false;
                totalST--;

            }

            else if (Starting11.Count == 11)
            {
                PlayerWarnings.text = ("You can only field a maximum of 11 players at a time");
            }
            else
            {
                PlayerWarnings.text = ("You should only be playing a maximum of two strikers ");


            }
        }

        if (ButtonID == 2)
        {
            if (totalST != 2 && Striker[ButtonID].Starting == false)
            {
                AddToLineup(Striker[ButtonID].PlayerID);
                STTracker[ButtonID].GetComponent<Image>().color = Color.grey;
                Striker[ButtonID].Starting = true;

                totalST++;
                STbtn1pressed = true;
            }
            else
            if (Striker[ButtonID].Starting == true && STbtn1pressed == true)
            {
                RemoveFromLineup(Striker[ButtonID].PlayerID);
                STTracker[ButtonID].GetComponent<Image>().color = Color.white;
                Striker[ButtonID].Starting = false;
                totalST--;

            }
            else if (Starting11.Count == 11)
            {
                PlayerWarnings.text = ("You can only field a maximum of 11 players at a time");
            }
            else
            {
                PlayerWarnings.text = ("You should only be playing a maximum of two strikers ");


            }
        }




        Debug.Log("new list");
        for (int i = 0; i < Starting11.Count(); i++)
        {

            Debug.Log(Starting11[i].Name +" " + Starting11[i].Position);

        }




        Debug.Log(Starting11.Count());

    }





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


    public void SelectCB(int ButtonID)
    {

        PlayerWarnings.text = "Choose 11 players to start";

        if (ButtonID == 0)
        {

            if (totalCB != 3 && CentreBacks[ButtonID].Starting == false)
            {
                AddToLineup(CentreBacks[ButtonID].PlayerID);
                CBTracker[ButtonID].GetComponent<Image>().color = Color.grey;
                CentreBacks[ButtonID].Starting = true;

                totalCB++;
                CBbtn1pressed = true;
            }
            else
            if (CentreBacks[ButtonID].Starting == true && CBbtn1pressed == true)
            {
                RemoveFromLineup(CentreBacks[ButtonID].PlayerID);
                CBTracker[ButtonID].GetComponent<Image>().color = Color.white;
                CentreBacks[ButtonID].Starting = false;
                totalCB--;

            }
            else if (Starting11.Count == 11)
            {
                PlayerWarnings.text = ("You can only field a maximum of 11 players at a time");
            }
            else
            {
                PlayerWarnings.text = ("You should only be playing a maximum of three Centre Backs ");

            }
        }

        if (ButtonID == 1)
        {

            if (totalCB != 3 && CentreBacks[ButtonID].Starting == false)
            {
                AddToLineup(CentreBacks[ButtonID].PlayerID);
                CBTracker[ButtonID].GetComponent<Image>().color = Color.grey;
                CentreBacks[ButtonID].Starting = true;

                totalCB++;
                CBbtn1pressed = true;
            }
            else
            if (CentreBacks[ButtonID].Starting == true && CBbtn1pressed == true)
            {
                RemoveFromLineup(CentreBacks[ButtonID].PlayerID);
                CBTracker[ButtonID].GetComponent<Image>().color = Color.white;
                CentreBacks[ButtonID].Starting = false;
                totalCB--;

            }
            else if (Starting11.Count == 11)
            {
                PlayerWarnings.text = ("You can only field a maximum of 11 players at a time");
            }
            else
            {
                PlayerWarnings.text = ("You should only be playing a maximum of three Centre Backs ");

            }
        }

        if (ButtonID == 2)
        {

            if (totalCB != 3 && CentreBacks[ButtonID].Starting == false)
            {
                AddToLineup(CentreBacks[ButtonID].PlayerID);
                CBTracker[ButtonID].GetComponent<Image>().color = Color.grey;
                CentreBacks[ButtonID].Starting = true;

                totalCB++;
                CBbtn1pressed = true;
            }
            else
            if (CentreBacks[ButtonID].Starting == true && CBbtn1pressed == true)
            {
                RemoveFromLineup(CentreBacks[ButtonID].PlayerID);
                CBTracker[ButtonID].GetComponent<Image>().color = Color.white;
                CentreBacks[ButtonID].Starting = false;
                totalCB--;

            }
            else if (Starting11.Count == 11)
            {
                PlayerWarnings.text = ("You can only field a maximum of 11 players at a time");
            }
            else
            {
                PlayerWarnings.text = ("You should only be playing a maximum of three Centre Backs ");

            }
        }


        if (ButtonID == 3)
        {

            if (totalCB != 3 && CentreBacks[ButtonID].Starting == false)
            {
                AddToLineup(CentreBacks[ButtonID].PlayerID);
                CBTracker[ButtonID].GetComponent<Image>().color = Color.grey;
                CentreBacks[ButtonID].Starting = true;

                totalCB++;
                CBbtn1pressed = true;
            }
            else
            if (CentreBacks[ButtonID].Starting == true && CBbtn1pressed == true)
            {
                RemoveFromLineup(CentreBacks[ButtonID].PlayerID);
                CBTracker[ButtonID].GetComponent<Image>().color = Color.white;
                CentreBacks[ButtonID].Starting = false;
                totalCB--;

            }
            else if (Starting11.Count == 11)
            {
                PlayerWarnings.text = ("You can only field a maximum of 11 players at a time");
            }
           

        }
        Debug.Log("new list");
            for (int i = 0; i < Starting11.Count(); i++)
            {

                Debug.Log(Starting11[i].Name + Starting11[i].Position);

            }

    }


    public void SelectMF(int ButtonID)
    {

        if (ButtonID == 0)
        {

            if (totalMF != 3 && MidFielders[ButtonID].Starting == false)
            {
                AddToLineup(MidFielders[ButtonID].PlayerID);
                MFTracker[ButtonID].GetComponent<Image>().color = Color.grey;
                MidFielders[ButtonID].Starting = true;

                totalMF++;
                MFbtn1pressed = true;
            }
            else
            if (MidFielders[ButtonID].Starting == true && MFbtn1pressed == true)
            {
                RemoveFromLineup(MidFielders[ButtonID].PlayerID);
                MFTracker[ButtonID].GetComponent<Image>().color = Color.white;
                MidFielders[ButtonID].Starting = false;
                totalMF--;

            }
            else if (Starting11.Count == 11)
            {
                PlayerWarnings.text = ("You can only field a maximum of 11 players at a time");
            }

        }

        if (ButtonID == 1)
        {

            if (totalMF != 3 && MidFielders[ButtonID].Starting == false)
            {
                AddToLineup(MidFielders[ButtonID].PlayerID);
                MFTracker[ButtonID].GetComponent<Image>().color = Color.grey;
                MidFielders[ButtonID].Starting = true;

                totalMF++;
                MFbtn1pressed = true;
            }
            else
            if (MidFielders[ButtonID].Starting == true && MFbtn1pressed == true)
            {
                RemoveFromLineup(MidFielders[ButtonID].PlayerID);
                MFTracker[ButtonID].GetComponent<Image>().color = Color.white;
                MidFielders[ButtonID].Starting = false;
                totalMF--;

            }
            else if (Starting11.Count == 11)
            {
                PlayerWarnings.text = ("You can only field a maximum of 11 players at a time");
            }

        }

        if (ButtonID == 2)
        {

            if (totalMF != 3 && MidFielders[ButtonID].Starting == false)
            {
                AddToLineup(MidFielders[ButtonID].PlayerID);
                MFTracker[ButtonID].GetComponent<Image>().color = Color.grey;
                MidFielders[ButtonID].Starting = true;

                totalMF++;
                MFbtn1pressed = true;
            }
            else
            if (MidFielders[ButtonID].Starting == true && MFbtn1pressed == true)
            {
                RemoveFromLineup(MidFielders[ButtonID].PlayerID);
                MFTracker[ButtonID].GetComponent<Image>().color = Color.white;
                MidFielders[ButtonID].Starting = false;
                totalMF--;

            }
            else if (Starting11.Count == 11)
            {
                PlayerWarnings.text = ("You can only field a maximum of 11 players at a time");
            }

        }

        if (ButtonID == 3)
        {

            if (totalMF != 3 && MidFielders[ButtonID].Starting == false)
            {
                AddToLineup(MidFielders[ButtonID].PlayerID);
                MFTracker[ButtonID].GetComponent<Image>().color = Color.grey;
                MidFielders[ButtonID].Starting = true;

                totalMF++;
                MFbtn1pressed = true;
            }
            else
            if (MidFielders[ButtonID].Starting == true && MFbtn1pressed == true)
            {
                RemoveFromLineup(MidFielders[ButtonID].PlayerID);
                MFTracker[ButtonID].GetComponent<Image>().color = Color.white;
                MidFielders[ButtonID].Starting = false;
                totalMF--;

            }
            else if (Starting11.Count == 11)
            {
                PlayerWarnings.text = ("You can only field a maximum of 11 players at a time");
            }

        }


        if (ButtonID == 4)
        {

            if (totalMF != 3 && MidFielders[ButtonID].Starting == false)
            {
                AddToLineup(MidFielders[ButtonID].PlayerID);
                MFTracker[ButtonID].GetComponent<Image>().color = Color.grey;
                MidFielders[ButtonID].Starting = true;

                totalMF++;
                MFbtn1pressed = true;
            }
            else
            if (MidFielders[ButtonID].Starting == true && MFbtn1pressed == true)
            {
                RemoveFromLineup(MidFielders[ButtonID].PlayerID);
                MFTracker[ButtonID].GetComponent<Image>().color = Color.white;
                MidFielders[ButtonID].Starting = false;
                totalMF--;

            }
            else if (Starting11.Count == 11)
            {
                PlayerWarnings.text = ("You can only field a maximum of 11 players at a time");
            }

        }


        if (ButtonID == 5)
        {

            if (totalMF != 3 && MidFielders[ButtonID].Starting == false)
            {
                AddToLineup(MidFielders[ButtonID].PlayerID);
                MFTracker[ButtonID].GetComponent<Image>().color = Color.grey;
                MidFielders[ButtonID].Starting = true;

                totalMF++;
                MFbtn1pressed = true;
            }
            else
            if (MidFielders[ButtonID].Starting == true && MFbtn1pressed == true)
            {
                RemoveFromLineup(MidFielders[ButtonID].PlayerID);
                MFTracker[ButtonID].GetComponent<Image>().color = Color.white;
                MidFielders[ButtonID].Starting = false;
                totalMF--;

            }
            else if (Starting11.Count == 11)
            {
                PlayerWarnings.text = ("You can only field a maximum of 11 players at a time");
            }
       

        }
        Debug.Log("new list");
            for (int i = 0; i < Starting11.Count(); i++)
            {

                Debug.Log(Starting11[i].Name + "  " + Starting11[i].Position);

            }
    }





    public void displayOptions()
    {
        PlayerWarnings = GameObject.Find("PlayerWarnings").GetComponent<Text>();
        SquadCapabilitiesText = GameObject.Find("SquadCapabilitiesText").GetComponent<Text>();
       


        SToption1 = GameObject.Find("SToption1").GetComponent<Button>();
        SToption2 = GameObject.Find("SToption2").GetComponent<Button>();
        SToption3 = GameObject.Find("SToption3").GetComponent<Button>();
        STTracker.Add(SToption1);
        STTracker.Add(SToption2);
        STTracker.Add(SToption3);

        MFoption1 = GameObject.Find("MFoption1").GetComponent<Button>();
        MFoption2 = GameObject.Find("MFoption2").GetComponent<Button>();
        MFoption3 = GameObject.Find("MFoption3").GetComponent<Button>();
        MFoption4 = GameObject.Find("MFoption4").GetComponent<Button>();
        MFoption5 = GameObject.Find("MFoption5").GetComponent<Button>();
        MFoption6 = GameObject.Find("MFoption6").GetComponent<Button>();
        MFTracker.Add(MFoption1);
        MFTracker.Add(MFoption2);
        MFTracker.Add(MFoption3);
        MFTracker.Add(MFoption4);
        MFTracker.Add(MFoption5);
        MFTracker.Add(MFoption6);

        LeftMoption1 = GameObject.Find("LMoption1").GetComponent<Button>();
        LeftMoption2 = GameObject.Find("LMoption2").GetComponent<Button>();
        LMTracker.Add(LeftMoption1);
        LMTracker.Add(LeftMoption2);

        RightMoption1 = GameObject.Find("RMoption1").GetComponent<Button>();
        RightMoption2 = GameObject.Find("RMoption2").GetComponent<Button>();
        RMTracker.Add(RightMoption1);
        RMTracker.Add(RightMoption2);

        LBoption1 = GameObject.Find("LBoption1").GetComponent<Button>();
        LBoption2 = GameObject.Find("LBoption2").GetComponent<Button>();

        LBTracker.Add(LBoption1);
        LBTracker.Add(LBoption2);

        RBoption1 = GameObject.Find("RBoption1").GetComponent<Button>();
        RBoption2 = GameObject.Find("RBoption2").GetComponent<Button>();

        RBTracker.Add(RBoption1);
        RBTracker.Add(RBoption2);

        CBoption1 = GameObject.Find("CBoption1").GetComponent<Button>();
        CBoption2 = GameObject.Find("CBoption2").GetComponent<Button>();
        CBoption3 = GameObject.Find("CBoption3").GetComponent<Button>();
        CBoption4 = GameObject.Find("CBoption4").GetComponent<Button>();

        CBTracker.Add(CBoption1);
        CBTracker.Add(CBoption2);
        CBTracker.Add(CBoption3);
        CBTracker.Add(CBoption4);

        GKoption1 = GameObject.Find("GKoption1").GetComponent<Button>();
        GKoption2 = GameObject.Find("GKoption2").GetComponent<Button>();

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


        public void displayPlayers(List<Starting11Info> playerTracker, List<Button> buttons)
        {
            for (int i = 0;i < playerTracker.Count(); i++)
            {

                buttons[i].GetComponentInChildren<Text>().text = playerTracker[i].Name + "\n " + playerTracker[i].Overall ;

                
                if (playerTracker[i].Overall >= 85)
                {
                buttons[i].GetComponentInChildren<Text>().color = Color.red;
                }

                if (playerTracker[i].Form >= 75)
                {
                    buttons[i].GetComponent<Image>().color = Color.green;
                }
                if (playerTracker[i].Form < 70)
                {
                    buttons[i].GetComponent<Image>().color = Color.yellow;
                }
        }

        }



    




        public void ViewPosessionPlan()
    {

        PossesionBtn = GameObject.Find("PossesionBtn").GetComponent<Button>();
        GameplanCapabilityText.text = ("Gameplan Capability: " + returnPossessionPlan(SelectedSquad, TeamSetup.TeamManagedID));
        CurrentGameplanText.text = ("Possesion");

    }


    public int returnPossessionPlan(List<PlayerInfo> CurrSquad, int teamid)
    {


        int PossesionTotal = 0;
        int Possesioncounter = 0;
        int i = 0;
        List<int> PossesionAverage = new List<int>();

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

        return CurrentTeamPossesion;


    }



    public void ViewCounterPlan()
    {

        CounterBtn = GameObject.Find("CounterBtn").GetComponent<Button>();
        GameplanCapabilityText.text = ("Gameplan Capability: " + returnCounterPlan(SelectedSquad, TeamSetup.TeamManagedID));
        CurrentGameplanText.text = ("Counter");




    }

    public int returnCounterPlan(List<PlayerInfo> CurrSquad, int teamid)
    {
        int CounterTotal = 0;
        int Countercounter = 0;
        int i = 0;
        List<int> CounterAverage = new List<int>();

        for (i = 0; i <= 22; i++)
        {
            if (CurrSquad[i].Position == "ST")
            {
                CounterTotal = 0;
                CounterTotal = CounterTotal + CurrSquad[i].Pace;
                CounterTotal = CounterTotal + CurrSquad[i].Dribbling;
                CounterTotal = CounterTotal + CurrSquad[i].Shooting;
                CounterAverage.Add(CounterTotal / 3);
            }

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



        return CurrentTeamCounter;



    }



    public void ViewPressurePlan()
    {
        PressureBtn = GameObject.Find("PressureBtn").GetComponent<Button>();
        GameplanCapabilityText.text = ("Gameplan Capability: " + returnPressurePlan(SelectedSquad, TeamSetup.TeamManagedID));
        CurrentGameplanText.text = ("Pressure");


    }

    public int returnPressurePlan(List<PlayerInfo> CurrSquad, int teamid)
    {

        int PressureTotal = 0;
        int Pressurecounter = 0;
        int i = 0;
        List<int> PressureAverage = new List<int>();

        for (i = 0; i <= 22; i++)
        {
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

        return CurrentTeamPressure;




    }





    public void CalculateCurrOverall()
    {
        TeamOverallText = GameObject.Find("TeamOverallText").GetComponent<Text>();
        int total = 0;
        //CurrentTeamOverall
        for (int i = 0; i <= 22; i++)
        {
            total = total + SelectedSquad[i].Overall;



        }

        CurrentTeamOverall = total / 23;


        TeamOverallText.text = ("Team Overall: " + CurrentTeamOverall);

    }





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

            LeagueTeamList[i].text = myteam.teaminfo[SortedTeams[i].TeamID].Name;
            LeagueWinsList[i].text = SortedTeams[i].Wins.ToString();
            LeagueLossesList[i].text = SortedTeams[i].Losses.ToString();
            LeagueDrawsList[i].text = SortedTeams[i].Draws.ToString();
            LeaguePointsList[i].text = SortedTeams[i].Points.ToString();

        }


    }

    public void RetrievePos()
    {
        TablePositionText = GameObject.Find("TablePositionText").GetComponent<Text>();
        int i = 0;
        bool found = false;

        while (found == false)
        {

            if (SortedTeams[i].TeamID == TeamSetup.TeamManagedID)
            {

                found = true;
            }
            else
            {
                i++;


            }

        }

        if (i == 0)
        {

            TablePositionText.text = "Table Position: 1st";


        }

        if (i == 1)
        {

            TablePositionText.text = "Table Position: 2nd";


        }

        if (i == 2)
        {

            TablePositionText.text = "Table Position: 3rd";


        }


        if (i == 3)
        {

            TablePositionText.text = "Table Position: 4th";


        }

        if (i == 4)
        {

            TablePositionText.text = "Table Position: 5th";


        }



        if (i == 5)
        {

            TablePositionText.text = "Table Position: 6th";


        }

        if (i == 6)
        {

            TablePositionText.text = "Table Position: 7th";


        }

        if (i == 7)
        {

            TablePositionText.text = "Table Position: 8th";


        }

        if (i == 8)
        {

            TablePositionText.text = "Table Position: 9th";


        }


        if (i == 9)
        {

            TablePositionText.text = "Table Position: 10th";


        }

        if (i == 10)
        {

            TablePositionText.text = "Table Position: 11th";


        }

        if (i == 11)
        {

            TablePositionText.text = "Table Position: 12th";


        }

    }



   public void PointsUpdater()
    {
        int WinsCounter = 0;
   

        // updates the points each team has based on wins and losses 
        for (int i = 0; i <= 11; i++)
        {
            WinsCounter = 0;

            WinsCounter = TableStats[i].Wins;
            WinsCounter = WinsCounter * 3;

            TableStats[i].Points =  WinsCounter;
                
               
            TableStats[i].Points = TableStats[i].Points + TableStats[i].Draws;
                

        }

        //sorting the list
            SortedTeams = TableStats.OrderByDescending(x => x.Points).ToList();

        


    }
















    public void selectSquad()
    {

        for (int i = 0; i <= 275; i++)
        {
            if (myplayer.playerinfo[i].TeamID == TeamSetup.TeamManagedID)
            {

                SelectedSquad.Add(myplayer.playerinfo[i]);

      

            }



        }


    }

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

            //Debug.Log(SelectedSquad[i].Name + " " + SelectedSquad[i].Position);

        }

        SquadNameList[11].gameObject.SetActive(false);
        SquadPositionList[11].gameObject.SetActive(false);
        SquadOverallList[11].gameObject.SetActive(false);
        SquadAgeList[11].gameObject.SetActive(false);
        SquadFormList[11].gameObject.SetActive(false);
        SquadMoraleList[11].gameObject.SetActive(false);
        MoreInfoBtn12.gameObject.SetActive(false);


    }




    public void BackSquadPage()
    {

        SquadNameList[11].gameObject.SetActive(true);
        SquadPositionList[11].gameObject.SetActive(true);
        SquadOverallList[11].gameObject.SetActive(true);
        SquadAgeList[11].gameObject.SetActive(true);
        SquadFormList[11].gameObject.SetActive(true);
        SquadMoraleList[11].gameObject.SetActive(true);
        MoreInfoBtn12.gameObject.SetActive(true);




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



    }











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
        MoreInfoBtn = GameObject.Find("MoreInfoBtn").GetComponent<Button>();


        NameHeader1 = GameObject.Find("NameHeader (1)").GetComponent<Text>();
        AgeHeader1 = GameObject.Find("AgeHeader (1)").GetComponent<Text>();
        PositionHeader1 = GameObject.Find("PositionHeader (1)").GetComponent<Text>();
        OverallHeader1 = GameObject.Find("OverallHeader (1)").GetComponent<Text>();
        FormHeader1 = GameObject.Find("FormHeader (1)").GetComponent<Text>();
        MoraleHeader1 = GameObject.Find("MoraleHeader (1)").GetComponent<Text>();
        MoreInfoBtn1 = GameObject.Find("MoreInfoBtn (1)").GetComponent<Button>();

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
        MoreInfoBtn2 = GameObject.Find("MoreInfoBtn (2)").GetComponent<Button>();

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
        MoreInfoBtn3 = GameObject.Find("MoreInfoBtn (3)").GetComponent<Button>();

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
        MoreInfoBtn4 = GameObject.Find("MoreInfoBtn (4)").GetComponent<Button>();

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
        MoreInfoBtn5 = GameObject.Find("MoreInfoBtn (5)").GetComponent<Button>();

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
        MoreInfoBtn6 = GameObject.Find("MoreInfoBtn (6)").GetComponent<Button>();

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
        MoreInfoBtn7 = GameObject.Find("MoreInfoBtn (7)").GetComponent<Button>();

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
        MoreInfoBtn8 = GameObject.Find("MoreInfoBtn (8)").GetComponent<Button>();

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
        MoreInfoBtn9 = GameObject.Find("MoreInfoBtn (9)").GetComponent<Button>();

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
        MoreInfoBtn10 = GameObject.Find("MoreInfoBtn (10)").GetComponent<Button>();

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
        MoreInfoBtn11 = GameObject.Find("MoreInfoBtn (11)").GetComponent<Button>();

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
        MoreInfoBtn12 = GameObject.Find("MoreInfoBtn (12)").GetComponent<Button>();



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




    public void updateFaith()
    {
        BoardText = GameObject.Find("BoardText").GetComponent<Text>();
        FanText = GameObject.Find("FanText").GetComponent<Text>();
      //  ManagerText = GameObject.Find("ManagerText").GetComponent<Text>();



        BoardText.text = ("Board Faith: " + (100 - myteam.teaminfo[TeamSetup.TeamManagedID].BoardDiff));
        FanText.text = ("Fan Faith: " + (100 - myteam.teaminfo[TeamSetup.TeamManagedID].FanDiff));
      //  ManagerText.text = ("Your Stress Level: " + Manager.ManStress);

    }
    public void CalculateCurrentThreat()
    {

        AttackingThreatText = GameObject.Find("AttackingThreatText").GetComponent<Text>();
        DefensiveThreatText = GameObject.Find("DefensiveThreatText").GetComponent<Text>();



        int attackTracker = OppositionAttackThreat(SelectedSquad, TeamSetup.TeamManagedID);

        int defenceTracker = OppositionDefenceThreat(SelectedSquad, TeamSetup.TeamManagedID);

        AttackingThreatText.text = ("Attacking Threat: " + attackTracker.ToString());
        DefensiveThreatText.text = ("Defensive Strength: " + defenceTracker.ToString());




    }

    public void teamInfoDisplay()
    {
        CurrentGameplanText = GameObject.Find("CurrentGameplanText").GetComponent<Text>();
        GameplanCapabilityText = GameObject.Find("GameplanCapabilityText").GetComponent<Text>();

        //DisplaySquadChoice();

        CalculateCurrOverall();
        
        RetrievePos();
 
        CalculateCurrentThreat();
 

    }

    public void OppositionTeamInfo()
    {
        List<PlayerInfo> TempSelectedSquad = new List<PlayerInfo>();

        for (int i = 0; i <= 11; i++)
        {
            TempSelectedSquad.Clear();
                for (int j = 0; j <= 275; j++)
                {
                    if (myplayer.playerinfo[j].TeamID == i)
                    {
                        TempSelectedSquad.Add(myplayer.playerinfo[j]);
                        //Debug.Log(myplayer.playerinfo[j].Name + " team ID:" + i );
                    }


                }


            myteam.teaminfo[i].Attack = OppositionAttackThreat(TempSelectedSquad, i);
            myteam.teaminfo[i].Defence = OppositionAttackThreat(TempSelectedSquad, i);

            OppositionInfo t = new OppositionInfo();

            t.CounterCapability = returnCounterPlan(TempSelectedSquad,i);
       
            t.PressureCapability = returnPressurePlan(TempSelectedSquad, i);

            t.PossessionCapability = returnPossessionPlan(TempSelectedSquad, i);

            t.TeamID = i;

            oppinfo.Add(t);
          //  Debug.Log(oppinfo[i].CounterCapability + " " + oppinfo[i].PossessionCapability + " " + oppinfo[i].PressureCapability);
        }

    
      
     

    }


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

       // Debug.Log("New Attack is" + CurrentTeamThreat);
        return CurrentTeamThreat;
        




    }



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

       // Debug.Log("New Defence is" + CurrentTeamDefence);
        return CurrentTeamDefence;
        






    }


    public int[] AwayFixtures(int GameWeek)
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

            return AwayTeams;

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
            return AwayTeams;

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
            return AwayTeams;

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

            return AwayTeams;
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

            return AwayTeams;

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
            return AwayTeams;
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


            return AwayTeams;

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

            return AwayTeams;

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


            return AwayTeams;

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

            return AwayTeams;
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

            return AwayTeams;

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

            return AwayTeams;

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

            return AwayTeams;

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

            return AwayTeams;

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

            return AwayTeams;
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

            return AwayTeams;

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

            return AwayTeams;
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


            return AwayTeams;

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

            return AwayTeams;

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

            return AwayTeams;

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

            return AwayTeams;
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

            return AwayTeams;

        }



            return null;


    }



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
                t.AwayScorers = "" ;
          
                MatchStats.Add(t);
               // Debug.Log(myteam.teaminfo[MatchStats[i].HomeID].Name + "  " + myteam.teaminfo[MatchStats[i].HomeID].ID + "  " + myteam.teaminfo[MatchStats[i].AwayID].Name + "  " + myteam.teaminfo[MatchStats[i].AwayID].ID);
       
            }
            return MatchStats;



    }








    public void Matchday()
    {


        Debug.Log("GameWeek: " + GameWeek);

        if (GameWeek > 22)
        {

            Debug.Log("Season Over");
        }
        else
        {

            AwayTeams = AwayFixtures(GameWeek);

            OppositionTeamInfo();
   

            MatchStats = ScheduleMatches(MatchStats);


            MatchStats = MatchResults(MatchStats);
            DisplayResult(MatchStats);
            PointsUpdater();

            GameWeek++;

   



        }


    }


    public void DisplayResult(List<MatchDayInfo> MatchInfo)
    {
        FinalScoreText = GameObject.Find("FinalScoreText").GetComponent<Text>();
        GameDayText = GameObject.Find("GameDayText").GetComponent<Text>();
        FoulsText = GameObject.Find("FoulsText").GetComponent<Text>();
        ScorersText = GameObject.Find("ScorersText").GetComponent<Text>();
        CardsText = GameObject.Find("CardsText").GetComponent<Text>();

        int playerTrack = 0;
        for (int i = 0; i <= 5; i++)
        {

            if (MatchInfo[i].AwayID == TeamSetup.TeamManagedID)
            {

                playerTrack = i;

            }

            if (MatchInfo[i].HomeID == TeamSetup.TeamManagedID)
            {

                playerTrack = i;

            }


        }

        FinalScoreText.text = (myteam.teaminfo[MatchInfo[playerTrack].HomeID].Name + "  " + MatchInfo[playerTrack].HomeGoals + " VS " + myteam.teaminfo[MatchInfo[playerTrack].AwayID].Name + "  " + MatchInfo[playerTrack].AwayGoals);
        GameDayText.text = ("Match Week: " + GameWeek);

        FoulsText.text = ("Home Fouls: " + MatchInfo[playerTrack].HomeFouls + " Away Fouls: " + MatchInfo[playerTrack].AwayFouls);

        ScorersText.text = ("Home Scorers: " + MatchInfo[playerTrack].HomeScorers + " Away Scorers: " + MatchInfo[playerTrack].AwayScorers);
        CardsText.text = ("Home Cards: " + MatchInfo[playerTrack].HomeYellows + " Away Cards: " + MatchInfo[playerTrack].AwayYellows);
    }



    public List<MatchDayInfo> MatchResults(List<MatchDayInfo> MatchInfo)
    {
        int HomeBasicOverall = 0;
        int AwayBasicOverall = 0;
        int HomeTactic = 0;
        int AwayTactic = 0;

    
        //looping round for every match that is to be played on a specific match day.
        for (int i = 0; i <= 5; i++)
        {
            HomeTactic = 0;
            AwayTactic = 0;
            //Firstly checking that each team will employ an appropiate gameplan against their opposition.

            HomeBasicOverall = (myteam.teaminfo[MatchInfo[i].HomeID].Attack + myteam.teaminfo[MatchInfo[i].HomeID].Defence) / 2;
            AwayBasicOverall = (myteam.teaminfo[MatchInfo[i].AwayID].Attack + myteam.teaminfo[MatchInfo[i].AwayID].Defence) / 2;


            //Significantly weaker teams will automatically opt for the counter option as catching the opposition on a break will be their best chance for success.
            //Slightly weaker teams should opt for pressure or counter depending on which they can execute better.
            int difference = HomeBasicOverall - AwayBasicOverall;

            if (difference > 10)
            {
                Debug.Log("Home is weak");
                AwayTactic = oppinfo[MatchInfo[i].AwayID].CounterCapability;

                HomeTactic = oppinfo[MatchInfo[i].HomeID].PossessionCapability;

            }

            difference = AwayBasicOverall - HomeBasicOverall;

            if (difference > 10)
            {
                Debug.Log("Away is weak");
                HomeTactic = oppinfo[MatchInfo[i].HomeID].CounterCapability;
                Debug.Log(oppinfo[MatchInfo[i].AwayID].PossessionCapability);
                AwayTactic = oppinfo[MatchInfo[i].AwayID].PossessionCapability;



            }

            HomeTactic = HomeTactic * RandomNumber(0, 100) ;
            AwayTactic = AwayTactic * RandomNumber(0, 100);
            //Dynamically prediciting the amount of goals that will be scored by each team on a specific match day. 

            if (HomeTactic > AwayTactic)
                {
                   
                    MatchInfo[i].HomeGoals = RandomNumber(1, 6);
                    MatchInfo[i].AwayGoals = RandomNumber(0, 6);


                }

                if (HomeTactic > AwayTactic)
                {
           
                    MatchInfo[i].HomeGoals = RandomNumber(0, 6);
                    MatchInfo[i].AwayGoals = RandomNumber(1, 6);


                }

                if (HomeTactic == AwayTactic)
                {
                    
                    MatchInfo[i].HomeGoals = RandomNumber(0, 4);
                    MatchInfo[i].HomeGoals = RandomNumber(0, 4);

                }







            //Applying the league stats

            myteam.teaminfo[MatchInfo[i].HomeID].Scored = myteam.teaminfo[MatchInfo[i].HomeID].Scored + MatchInfo[i].HomeGoals;
            myteam.teaminfo[MatchInfo[i].AwayID].Scored = myteam.teaminfo[MatchInfo[i].AwayID].Scored + MatchInfo[i].AwayGoals;

            // Adding Draws to each team


          

            if (MatchInfo[i].HomeGoals == MatchInfo[i].AwayGoals)
            {
                TableStats[MatchInfo[i].HomeID].Draws++;
                TableStats[MatchInfo[i].AwayID].Draws++;
             
            }

          
            //Adding a win to the winning team
            if (MatchInfo[i].HomeGoals > MatchInfo[i].AwayGoals)
            {
                TableStats[MatchInfo[i].HomeID].Wins++;
                TableStats[MatchInfo[i].AwayID].Losses++;

            }


            if (MatchInfo[i].HomeGoals < MatchInfo[i].AwayGoals)
            {
                TableStats[MatchInfo[i].AwayID].Wins++;
           
                TableStats[MatchInfo[i].HomeID].Losses++;

            }
   
            PointsUpdater();

            Debug.Log(myteam.teaminfo[MatchInfo[i].HomeID].Name + "  " + MatchInfo[i].HomeGoals + " points: " + TableStats[MatchInfo[i].HomeID].Points + " VS " + myteam.teaminfo[MatchInfo[i].AwayID].Name + "  " + MatchInfo[i].AwayGoals + " points: " + TableStats[MatchInfo[i].AwayID].Points);
           
        }
       
        PointsUpdater();

        Debug.Log("  ");
        return MatchInfo;

    }


   
   

    public static int RandomNumber(int min, int max)
    {
        lock (syncLock)
        { // synchronize
            return rnd.Next(min, max);
        }
    }




    public void UpdatePlayerInfo()
    {
        GameWeekTxt = GameObject.Find("GameWeekTxt").GetComponent<Text>();
        ManStressTxt = GameObject.Find("ManStressTxt").GetComponent<Text>();
        ManNameTxt = GameObject.Find("ManNameTxt").GetComponent<Text>();


        GameWeekTxt.text = ("Game Week: " + GameWeek) ;
        ManStressTxt.text = ("Stress Level: " + Manager.ManStress);
        ManNameTxt.text = ("Name: " + Manager.ManName);
    }



    public void initTableInfo()
    {

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





    void Start()
    {
        // for test purposes pre chosen team.
        TeamSetup.TeamManagedID = 2;
        GameWeek = 1;
        myteam.loadData();
        myplayer.loadPlayerData();
        myplayer.updateOverall();



        selectSquad();

        //updateFaith();

       // UpdatePlayerInfo();
        initTableInfo();
        PointsUpdater();
        // PopulateTable();

        //displayOptions();
    }




}






















































