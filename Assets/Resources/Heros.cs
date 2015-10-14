using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Heros : MonoBehaviour
{
    public string Name;
    public float HP;

    void GetChampionData(Champion c)
    {
        Name = c.Name;
        HP = c.HP;
    }

    void Start()
    {
    }

    private System.Object thisLock = new System.Object();
    private Champion GetRandomCard(List<Champion> allchamps)
    {
        lock (thisLock)
        {
            int random = UnityEngine.Random.Range(1, allchamps.Count - 1);

            return allchamps[random];
        }
    }
}
