using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManagement : MonoBehaviour
{

    public Text BoardText;
    public Text FanText;
    public Text ManagerText;
    public int BoardFaith;
    int i;
    int WinsCounter;
    int DrawsCounter;

    Team myteam = new Team();
    TeamSetup myTeamSetup = new TeamSetup();

    public void updateFaith()
    {   // for test purposes pre chosen team.
        TeamSetup.TeamManagedID = 3;
        BoardText.text = ("Board Faith: " + (100 - myteam.teaminfo[TeamSetup.TeamManagedID].BoardDiff));
        FanText.text = ("Fan Faith: " + (100 - myteam.teaminfo[TeamSetup.TeamManagedID].FanDiff));
        ManagerText.text = ("Your Stress Level: " + Manager.ManStress + " Your Reputation: " + Manager.ManReputation);

    }



    void Start()
    {
        myteam.loadData();

        BoardText = GameObject.Find("BoardText").GetComponent<Text>();
        FanText = GameObject.Find("FanText").GetComponent<Text>();
        ManagerText = GameObject.Find("ManagerText").GetComponent<Text>();
        updateFaith();

    }


    public void PointsUpdater()
    {

        for (i = 0; i <= 11; i++)
        {

            if (myteam.teaminfo[i].Wins > 0)
            {


            }



            Debug.Log(myteam.teaminfo[i].Points);
            i++;

        }


    }




















}



































