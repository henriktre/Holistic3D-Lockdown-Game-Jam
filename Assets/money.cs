using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class money : MonoBehaviour
{
    public Text moneyTxt;
    public int cash = 0;
    public int wage = 1;
    public float increment = 1.0f;
    float counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = increment;
    }

    // Update is called once per frame
    void Update()
    {
        if(counter > 0.0f)
        {
            counter -= Time.deltaTime;
           
        }
        else
        {
            cash += wage;
            moneyTxt.text = cash.ToString() + "$";
            counter = increment;
        }
        
    }

}
