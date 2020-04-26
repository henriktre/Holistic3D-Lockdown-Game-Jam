using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class button : MonoBehaviour
{
    public GameObject camera;
    public money money;

    void init()
    {
        camera = GameObject.FindWithTag("cam");
        money = camera.GetComponent<money>();
    }

    public void good()
    {
        init();
        money.cash += 100;
        deleteButton();
    }

    public void bad()
    {
        init();
        money.cash -= 100;
        deleteButton();
    }

    void deleteButton()
    {
        Destroy(transform.gameObject);
    }
}
