using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Gameplay : MonoBehaviour
{
    public Text BoardText;

    Team myteam = new Team();
    Manager mymanager = new Manager();

    


    int index = 0;
    public int TeamManagedID;
    public int BoardFaith;




    public void change()
    {
        if (index < 11)
        {
            index++;
            myteam.TeamSelect(index);
        }
        else
        {
            index = 0;
            myteam.TeamSelect(index);
        }




    }


    public void chooseTeam()
    {

        TeamManagedID = index;


        Debug.Log(TeamManagedID);

        BoardFaith = (100 - myteam.teaminfo[TeamManagedID].BoardDiff);

    }




    public void createManager()
    {
        mymanager.ManagerCreate();


    }


    // Start is called before the first frame update
    void Start()
    {
        myteam.loadData();

       




    }

    public void updateFaith()
    {

        BoardText = GameObject.Find("BoardText").GetComponent<Text>();

        BoardText.text = ("Board Faith: " + BoardFaith);



    }




}
