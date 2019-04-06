using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<PlayerInfo> playerinfo = new List<PlayerInfo>();

    int index = 0;
    int i;
    public TextAsset PlayerData;


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
                playerinfo.Add(t);
            }



        }



            

   






    }



    public void updateOverall()
    {

        for (i = 0; i <= 275; i++)
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













        for (i = 0; i <= 275; i++)
        {

            if (playerinfo[i].Overall >= 85)
            {
                playerinfo[i].Star = 100;
                playerinfo[i].Confidence = 80;

            }

        }














    }











}
