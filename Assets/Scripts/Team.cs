using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Team : MonoBehaviour
{
    
    public List<TeamInfo> teaminfo = new List<TeamInfo>();

    int index = 0; 



    public Text NameText;
    public Text ReputationText;
    public Text BudgetText;
    public Text AttackDefenceText;
    public Text GroundText;



    public void Start()
    {
        NameText = GameObject.Find("NameText").GetComponent<Text>();
        ReputationText = GameObject.Find("ReputationText").GetComponent<Text>();
        BudgetText = GameObject.Find("BudgetText").GetComponent<Text>();
        AttackDefenceText = GameObject.Find("AttackDefenceText").GetComponent<Text>();
        GroundText = GameObject.Find("GroundText").GetComponent<Text>();

        TextAsset TeamData = Resources.Load<TextAsset>("TeamData");



        string[] teamdata = TeamData.text.Split(new char[] { '\n' });
        Debug.Log(teamdata.Length);

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

        TeamSelect(0);
      


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
        Manager MyManager = new Manager();
        MyManager.ManTeamID = index;

    }




    public void TeamSelect(int index)
    {

            NameText.text = ("Name: " + teaminfo[index].Name);
            ReputationText.text = ("Reputation: " + teaminfo[index].Rep);
            BudgetText.text = ("Budget: " + teaminfo[index].Budget);
            AttackDefenceText.text = ("Attack/Defence: " + teaminfo[index].Attack + "/" + +teaminfo[index].Defence);
            GroundText.text = ("Ground: " + teaminfo[index].Ground);
        }







    }










