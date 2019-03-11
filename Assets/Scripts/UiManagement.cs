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


    public int BoardFaith;
    int i = 0;
    int WinsCounter;
    int DrawsCounter;

    Team myteam = new Team();
    Player myplayer = new Player();
    TeamSetup myTeamSetup = new TeamSetup();

    List<Text> Tlist = new List<Text>();


    public void PointsUpdater()
    {

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


    public void updateFaith()
    {   // for test purposes pre chosen team.
        TeamSetup.TeamManagedID = 0;
        BoardText.text = ("Board Faith: " + (100 - myteam.teaminfo[TeamSetup.TeamManagedID].BoardDiff));
        FanText.text = ("Fan Faith: " + (100 - myteam.teaminfo[TeamSetup.TeamManagedID].FanDiff));
        ManagerText.text = ("Your Stress Level: " + Manager.ManStress + " Your Reputation: " + Manager.ManReputation);

    }



    void Start()
    {
        myteam.loadData();
        myplayer.loadPlayerData();
        myplayer.updateOverall();

        BoardText = GameObject.Find("BoardText").GetComponent<Text>();
        FanText = GameObject.Find("FanText").GetComponent<Text>();
        ManagerText = GameObject.Find("ManagerText").GetComponent<Text>();


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



        updateFaith();
        PointsUpdater();
    }




}






















































