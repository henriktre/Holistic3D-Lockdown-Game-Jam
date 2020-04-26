using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliders : MonoBehaviour
{
    private Slider media;
    private Slider politicians;
    private Slider production;

    public float mediaValue;
    public float politiciansValue;
    public float productionValue;
    // Start is called before the first frame update
    void Start()
    {
        media = GameObject.Find("Media").GetComponent<Slider>();
        politicians = GameObject.Find("Politicians").GetComponent<Slider>();
        production = GameObject.Find("Production").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        media.value = mediaValue;
        politicians.value = politiciansValue;
        production.value = productionValue;
    }
}
