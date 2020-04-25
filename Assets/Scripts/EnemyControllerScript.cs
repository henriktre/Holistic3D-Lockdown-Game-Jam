using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControllerScript : MonoBehaviour
{

    //GameObject enemyScript;
    //EnemyAIScript enemyS;

    public EnemyAIScript enemy;

    // Start is called before the first frame update
    void Start()
    {
        //  enemyScript = GameObject.Find("Main Camera");
        //  enemyS = enemyScript.GetComponent<EnemyAIScript>();

        enemy = new EnemyAIScript();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
