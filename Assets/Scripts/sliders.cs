using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class sliders : MonoBehaviour
{
    private Slider media;
    private Slider politicians;
    private Slider production;

    public float mediaValue;
    public float politiciansValue;
    public float productionValue;
    public float mediaModifier = 1.0f;
    public float politiciansModifier = 1.0f;
    public float productionModifier = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        media = GameObject.FindWithTag("mediaSlider").GetComponent<Slider>();
        politicians = GameObject.FindWithTag("politiciansSlider").GetComponent<Slider>();
        production = GameObject.FindWithTag("ProductionSlider").GetComponent<Slider>();
    }

    // Update is called once per frame
    public void onMediaChanged(float value)
    {
        mediaValue = value * mediaModifier;

    }

    public void onPoliticiansChanged(float value)
    {

        politiciansValue = value * politiciansModifier;

    }

    public void onProductionChanged(float value)
    {
        productionValue = value * productionModifier;
    }
}
