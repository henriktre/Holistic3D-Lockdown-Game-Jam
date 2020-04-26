using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    public long worldPopulation = 7780366311;

    public float coverupStat = 0.99999f;
    public float coverupChange = 0.00001f;
    public float increment = 1.0f;
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
            float tmp = coverupStat * (float)worldPopulation;
            long tmp2 = (long)tmp;
            UnityEngine.Debug.Log(100-(coverupStat*100) + "% and " + (worldPopulation - tmp2) + " people knows the truth");
        }
    }
}
