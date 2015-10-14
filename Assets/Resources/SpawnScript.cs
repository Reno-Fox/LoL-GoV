using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SpawnScript : MonoBehaviour
{

    public GameObject obj;
    //public float spawnMin = 1f;
    //public float spawnMax = 2f;

    List<Champion> allchamps = new List<Champion>();

    private Object thisLock = new Object();

    private Champion GetRandomCard()
    {
        lock(thisLock)
        {
            int random = Random.Range(1, allchamps.Count - 1);

            return allchamps[random];
        }
    }

    // Use this for initialization
    void Start()
    {
        ChampionLoader load = new ChampionLoader();
        allchamps.AddRange(load.Start());

        Spawn();
        Spawn();
        Spawn();
        Spawn();
    }

    void Spawn()
    {
        Champion c = GetRandomCard();
        print(c.name);


        ////GameObject newCard = (GameObject)Instantiate(obj[Random.Range(0, obj.GetLength(0))], transform.position, Quaternion.identity);
        //GameObject newCard = (GameObject)Instantiate((GameObject)Resources.Load("Card"), transform.position, Quaternion.identity);
        ////Invoke("Spawn", Random.Range(spawnMin, spawnMax));
        //newCard.transform.SetParent(this.transform);
    }
}
