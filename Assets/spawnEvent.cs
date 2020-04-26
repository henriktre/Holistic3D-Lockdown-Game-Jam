using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class spawnEvent : MonoBehaviour
{
    public GameObject goodEvent;
    public GameObject badEvent;
    public Transform badEvents;
    public Transform goodEvents;
    public void SpawnGood()
    {
        GameObject myGoodEvent = Instantiate(goodEvent);

        myGoodEvent.transform.SetParent(goodEvents);
    }
    public void SpawnBad()
    {
        GameObject myBadEvent = Instantiate(badEvent);
        myBadEvent.transform.SetParent(badEvents);
    }
}
