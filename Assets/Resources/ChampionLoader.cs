using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChampionLoader : MonoBehaviour {

    public const string path = "champions";

 //   public void Start ()
 //   {
 //       ChampionContainer cc = ChampionContainer.Load(path);    

 //       foreach (Champion champion in cc.champions)
 //       {
 //           print(champion.Name);
 //       }
	//}

    public List<Champion> Start()
    {
        List<Champion> champs = new List<Champion>();

        ChampionContainer cc = ChampionContainer.Load(path);

        foreach (Champion champion in cc.champions)
        {
            champs.Add(champion);
        }

        return champs;
    }
}

//public class Heros : MonoBehaviour
//{
//    public string Name;
//    public float HP;

//    void GetChampionData(Champion c)
//    {
//        Name = c.Name;
//        HP = c.HP;
//    }

//    void Start()
//    {
//    }

//    private System.Object thisLock = new System.Object();
//    private Champion GetRandomCard(List<Champion> allchamps)
//    {
//        lock (thisLock)
//        {
//            int random = UnityEngine.Random.Range(1, allchamps.Count - 1);

//            return allchamps[random];
//        }
//    }
//}
