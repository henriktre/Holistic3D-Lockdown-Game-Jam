using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class product : MonoBehaviour
{
    public TextMeshProUGUI productTxt;
    public int products;
    public float increment = 0.5f;
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
            productTxt.text = products.ToString() + " Products";
            counter = increment;
        }

    }


}