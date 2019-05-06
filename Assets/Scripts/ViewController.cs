using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class ViewController : MonoBehaviour
{
    //Text objects to be used to display the scout report information
    public Text ScoutReportText;
    public Text ScoutReportTitle;
    public Text ScoutReportDetails;






    public int GameWeek = 1;

    //creating an instance of the model class
    private Model MyModel = new Model();





    //Every Time The matchday button is pressed
    //Controller then has Model prepare teams for matchday

    public void displayMatchPrep()
    {
        ScoutReportText = GameObject.Find("ScoutReportText").GetComponent<Text>();
        ScoutReportTitle = GameObject.Find("ScoutReportTitle").GetComponent<Text>();
        ScoutReportDetails = GameObject.Find("ScoutReportDetails").GetComponent<Text>();

        if (GameWeek > 22)
        {

            Debug.Log("Season Over");
        }
        else
        {

            ScoutReportText.text = MyModel.prepareTeams(GameWeek)[0];
            ScoutReportText.text = MyModel.prepareTeams(GameWeek)[1];
            ScoutReportText.text = MyModel.prepareTeams(GameWeek)[2];


        }


    }



    //Teams for matchday are prepared

       


















    // Start is called before the first frame update
    void Start()
    {

        MyModel.InitModel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
