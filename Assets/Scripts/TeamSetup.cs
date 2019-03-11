using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TeamSetup : MonoBehaviour
{


    Team myteam = new Team();
    Player myplayer = new Player();

     Text NameText;
    public Text ReputationText;
    public Text BudgetText;
    public Text AttackDefenceText;
    public Text GroundText;
    int i;
    int j;
    int AttackCount;
    int DefenceCount;

    int index = 0;
    static public int TeamManagedID;


 
   
    public void TeamSelect(int index)
    {
       NameText = GameObject.Find("NameText").GetComponent<Text>();
        ReputationText = GameObject.Find("ReputationText").GetComponent<Text>();
        BudgetText = GameObject.Find("BudgetText").GetComponent<Text>();
        AttackDefenceText = GameObject.Find("AttackDefenceText").GetComponent<Text>();
        GroundText = GameObject.Find("GroundText").GetComponent<Text>();

        NameText.text = ("Name: " + myteam.teaminfo[index].Name);
        ReputationText.text = ("Reputation: " + myteam.teaminfo[index].Rep);
        BudgetText.text = ("Budget: " + myteam.teaminfo[index].Budget);
        AttackDefenceText.text = ("Attack/Defence: " + myteam.teaminfo[index].Attack + "/" + myteam.teaminfo[index].Defence);
        GroundText.text = ("Ground: " + myteam.teaminfo[index].Ground);


    }







    public void change()
    {
        if (index < 11)
        {
            index++;
            TeamSelect(index);
        }
        else
        {
            index = 0;
        TeamSelect(index);
        }




    }


    public void chooseTeam()
    {
       
        TeamManagedID = index;


        

       

    }

    /*
    public void updateOverall()
    {
        for (i = 1; i <= myteam.teaminfo.Count; i++)
        {
            int count = 0;

            for (j = 1; j <= myplayer.playerinfo.Count; j++)
            {
                if (myplayer.playerinfo[j].Position == "CB")
                {
                    AttackCount = AttackCount + myplayer.playerinfo[j].Tackling;
                    count++;
                }

                else if (myplayer.playerinfo[j].Position == "LB")
                {
                    AttackCount = AttackCount + myplayer.playerinfo[j].Tackling;
                    count++;
                }

                else if (myplayer.playerinfo[j].Position == "RB")
                {
                    AttackCount = AttackCount + myplayer.playerinfo[j].Tackling;
                    count++;
                }




                myteam.teaminfo[i].Attack = myplayer.
            }


        }

    }


    */


    // Start is called before the first frame update
    void Start()
    {
            
        myteam.loadData();



        TeamSelect(0);




    }






}
