using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Menu : MonoBehaviour {

    public Button SubmitBtn;

    public int index = 0;

    TeamBehaviour teambehaviour = new TeamBehaviour();
  

    // Use this for initialization
    void Start () {


        SubmitBtn = GameObject.Find("SubmitBtn").GetComponent<Button>();
        teambehaviour.Start();
        teambehaviour.TeamSelect(0);
     


    }








    public void changeTeam()
    {

        if (index <= 2)
        {
            index++;
            teambehaviour.TeamSelect(index);
        }
        else
        {
            index = 0;
            teambehaviour.TeamSelect(index);
        }




    }



 
}
