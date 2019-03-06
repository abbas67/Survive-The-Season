using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManagement : MonoBehaviour
{

    public Text BoardText;
    public int BoardFaith;


    Team myteam = new Team();
    TeamSetup myTeamSetup = new TeamSetup();

    public void updateFaith()
    {
        
        BoardText.text = ("Board Faith: " + myteam.teaminfo[myTeamSetup.teammanagedid].BoardDiff);
        Debug.Log("test");


    }


   
    void Start()
    {
        myteam.loadData();

        BoardText = GameObject.Find("BoardText").GetComponent<Text>();
        updateFaith();
       
    }


}
