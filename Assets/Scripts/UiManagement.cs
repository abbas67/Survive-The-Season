using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;



public class UiManagement : MonoBehaviour
{

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

    int i = 0;
    int WinsCounter;
    int DrawsCounter;

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

    public List<PlayerInfo> SelectedSquad = new List<PlayerInfo>();


    public void PointsUpdater()
    {
        Pos0 = GameObject.Find("Pos0").GetComponent<Text>();
        Tlist.Add(Pos0);
        Pos1 = GameObject.Find("Pos1").GetComponent<Text>();
        Tlist.Add(Pos1);
        Pos2 = GameObject.Find("Pos2").GetComponent<Text>();
        Tlist.Add(Pos2);
        Pos3 = GameObject.Find("Pos3").GetComponent<Text>();
        Tlist.Add(Pos3);
        Pos4 = GameObject.Find("Pos4").GetComponent<Text>();
        Tlist.Add(Pos4);
        Pos5 = GameObject.Find("Pos5").GetComponent<Text>();
        Tlist.Add(Pos5);
        Pos6 = GameObject.Find("Pos6").GetComponent<Text>();
        Tlist.Add(Pos6);
        Pos7 = GameObject.Find("Pos7").GetComponent<Text>();
        Tlist.Add(Pos7);
        Pos8 = GameObject.Find("Pos8").GetComponent<Text>();
        Tlist.Add(Pos8);
        Pos9 = GameObject.Find("Pos9").GetComponent<Text>();
        Tlist.Add(Pos9);
        Pos10 = GameObject.Find("Pos10").GetComponent<Text>();
        Tlist.Add(Pos10);
        Pos11 = GameObject.Find("Pos11").GetComponent<Text>();
        Tlist.Add(Pos11);

        // updates the points each team has based on wins and losses 
        for (i = 0; i <= 11; i++)
        {

            if (myteam.teaminfo[i].Wins != 0)
            {
                WinsCounter = (myteam.teaminfo[i].Wins * 3);
                myteam.teaminfo[i].Points = myteam.teaminfo[i].Points + WinsCounter;
            }

            if (myteam.teaminfo[i].Draws != 0)
            {
                DrawsCounter = (myteam.teaminfo[i].Draws);
                myteam.teaminfo[i].Points = myteam.teaminfo[i].Points + DrawsCounter;
            }

        }

        //sorting the list
        List<TeamInfo> SortedTeams = myteam.teaminfo.OrderByDescending(x => x.Points).ToList();




        for (i = 0; i <= 11; i++)
        {
            Tlist[i].text = (SortedTeams[i].Name + "            " + SortedTeams[i].Wins + "             " + SortedTeams[i].Losses + "           " + SortedTeams[i].Draws + "            " + SortedTeams[i].Points);

        }






    }

    public void selectSquad()
    {
       
        for (i = 0; i <= 45; i++)
        {
            if (myplayer.playerinfo[i].TeamID == TeamSetup.TeamManagedID)
            {

                SelectedSquad.Add(myplayer.playerinfo[i]);


            }



        }


    }


    public void populateSquad()
    {


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


        for (i = 0; i <= 12; i++)
        {

            SquadNameList[i].text = SelectedSquad[i].Name;
            SquadPositionList[i].text = SelectedSquad[i].Position;
            SquadOverallList[i].text = SelectedSquad[i].Overall.ToString();
            SquadAgeList[i].text = SelectedSquad[i].Age.ToString();
            SquadFormList[i].text = SelectedSquad[i].Form.ToString();
            SquadMoraleList[i].text = SelectedSquad[i].Morale.ToString();

            Debug.Log(SelectedSquad[i].Name + " " + SelectedSquad[i].Position);

        }



    }





    public void updateFaith()
    {   
        BoardText.text = ("Board Faith: " + (100 - myteam.teaminfo[TeamSetup.TeamManagedID].BoardDiff));
        FanText.text = ("Fan Faith: " + (100 - myteam.teaminfo[TeamSetup.TeamManagedID].FanDiff));
        ManagerText.text = ("Your Stress Level: " + Manager.ManStress + " Your Reputation: " + Manager.ManReputation);

    }



    void Start()
    {
        // for test purposes pre chosen team.
        TeamSetup.TeamManagedID = 1;

        myteam.loadData();
        myplayer.loadPlayerData();
        myplayer.updateOverall();
        selectSquad();
        populateSquad();

        BoardText = GameObject.Find("BoardText").GetComponent<Text>();
        FanText = GameObject.Find("FanText").GetComponent<Text>();
        ManagerText = GameObject.Find("ManagerText").GetComponent<Text>();




       // updateFaith();
       // PointsUpdater();
       
    }




}






















































