using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameControllerScript : MonoBehaviour
{
    public spawnEvent spawnEvent;
    public sliders sliders;
    public money money;
    public political political;
    public product product;
    public GameObject win;
    public GameObject lose;
    public bool quit = false;

    public long worldPopulation = 7780366311;
    public TextMeshProUGUI coverupTxt;
    public decimal coverupStat = 0.95m;
    public decimal coverupChange = 0.0001m;
    public float increment = 0.1f;
    public float counter;


    // Start is called before the first frame update
    void Start()
    {
        //coverupStat = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (counter > 0.0f || quit)
        {
            counter -= Time.deltaTime;

            if (counter < -5.0f)
            {
                Application.Quit();
            }

        }
        else
        {
            //sliders
            Media();
            Politicians();
            Production();

            coverupStat -= coverupChange;

            if(!quit)
            {
                counter = increment;
            }
              
            decimal tmp = coverupStat * (decimal)worldPopulation;
            long tmp2 = (long)tmp;
            coverupTxt.text = decimal.Round((coverupStat*100), 2, System.MidpointRounding.AwayFromZero) + "% of the population believes the conspiracy\n" + tmp2 + " people believes the conspiracy";
            if (Random.value > 0.95f)
            {
                spawnEvent.SpawnGood();
            }
            if (Random.value > 0.96f)
            {
                spawnEvent.SpawnBad();
            }
            if(money.cash < 0 || coverupStat < 0)
            {//LOSE CONDITION
                quit = true;
                lose.SetActive(true);
            }
            if(coverupStat > 1)
            {
                quit = true;
                win.SetActive(true);
            }
            


        }
    }
    /* 
    public float mediaValue;
    public float politiciansValue;
    public float productionValue;
 */
    void Media() //costs coverupChange + 0.0005m , gives wage + 50 
    {
        if (Random.value < sliders.mediaValue)
        {
            coverupStat -= ((decimal)sliders.mediaValue * 0.02m);
            money.cash += (int)(sliders.mediaValue * 100.0f);
        }
    }
    void Politicians() //costs wage -50, gives influence + 3
    {
        if (Random.value < sliders.politiciansValue)
        {
            money.cash -= (int)(sliders.politiciansValue * 50.0f);
            political.politicians += 3;
            UnityEngine.Debug.Log("political: " + (int)(sliders.politiciansValue * 50.0f));
        }

    }
    void Production() // cost wage -50, gives production + 0.05
    {
        
        if (Random.value < (sliders.productionValue))
        {
            money.cash -= (int)(sliders.productionValue * 50.0f);
            if (Random.value > 0.80f)
            {
                product.products++;
            }
        }
        

    }
}
