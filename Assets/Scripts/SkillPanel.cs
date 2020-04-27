using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class SkillPanel : MonoBehaviour
{
    public money money;
    public political political;
    public GameControllerScript gcs;
    public product product;
    public sliders sliders;

    //CHANGE THIS
    public void NewCoke()
    {
        if (gcs.coverupStat > 0.5m && product.products > 0)
        {
            product.products--;
            gcs.coverupChange += 0.00005m;
            sliders.productionModifier = sliders.productionModifier * 0.99f;
        }
    }

    public void Chemtrails()
    {
        if (money.cash > 500 && product.products > 0)
        {
            product.products--;
            money.cash -= 500;
            gcs.coverupChange -= 0.00005m;
        }

    }

    public void Mindcontrol()
    {
        if (money.cash > 250 && product.products > 0)
        {
            product.products--;
            money.cash -= 250;
            political.politicians += 1;
        }

    }

    public void Moonlanding()
    {
        if (political.politicians >= 10 && money.cash > 250 && product.products > 0)
        {
            product.products--;
            political.politicians -= 10;
            money.cash -= 250;
            gcs.coverupChange -= 0.00005m;
        }

    }

    //CHANGE THIS
    public void Paulisdead()
    {
        if (political.politicians >= 10 && money.cash > 250 && product.products > 0)
        {
            product.products--;
            political.politicians -= 10;
            money.cash -= 500;
            sliders.mediaModifier = sliders.mediaModifier * 1.01f;
        }

    }

    public void Mytube()
    {
        if (political.politicians >= 10 && money.cash > 250 && product.products > 0)
        {
            product.products--;
            political.politicians -= 10;
            money.cash -= 250;
            gcs.coverupStat -= 0.01m;
        }

    }

    public void Assassination()
    {
        if(political.politicians >= 30 && product.products > 0)
        {
            product.products--;
            political.politicians -= 30;
            gcs.coverupChange -= 0.00005m;

        }
    }

    public void RigElection()
    {
       
        if(political.politicians >= 120 && product.products > 0)
        {
            product.products--;
            political.politicians -= 120;
            political.influence += 1;
        }
       
    }

    public void SecretArmy()
    {
        if(political.politicians >= 30 && product.products > 0)
        {
            product.products--;
            political.politicians -= 30;
            gcs.coverupStat -= 0.01m;
        }
    }
    
}
