using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class money : MonoBehaviour
{
    public TextMeshProUGUI moneyTxt;
    public int cash;
    public int wage;
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
            cash += wage;
            moneyTxt.text = cash.ToString() + "M$";
            counter = increment;
        }

    }
    

}
