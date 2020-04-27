using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class political : MonoBehaviour
{
    public TextMeshProUGUI politicalTxt;
    public int politicians;
    public int influence;
    public float increment = 0.2f;
    float counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = increment;
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
            if(UnityEngine.Random.value > 0.90f)
            {
                politicians += influence;
                
            }
            politicalTxt.text = politicians.ToString() + " Politicians";
            counter = increment;
        }

    }


}
