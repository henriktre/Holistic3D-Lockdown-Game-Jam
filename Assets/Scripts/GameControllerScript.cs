using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using TMPro;

public class GameControllerScript : MonoBehaviour
{
    public long worldPopulation = 7780366311;
    public TextMeshProUGUI coverupTxt;
    public decimal coverupStat = 0.95m;
    public decimal coverupChange = 0.0001m;
    public float increment = 0.1f;
    float counter;


    // Start is called before the first frame update
    void Start()
    {
        //coverupStat = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (counter > 0.0f)
        {
            counter -= Time.deltaTime;

        }
        else
        {
            coverupStat -= coverupChange;
            counter = increment;
            decimal tmp = coverupStat * (decimal)worldPopulation;
            long tmp2 = (long)tmp;
            coverupTxt.text = decimal.Round((coverupStat*100), 2, System.MidpointRounding.AwayFromZero) + "% \n" + tmp2;
        }
    }
}
