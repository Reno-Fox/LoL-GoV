using UnityEngine;
using System.Collections;

public class CardLoader : MonoBehaviour {

    public const string path = "cards";

	// Use this for initialization
	void Start () {
        CardContainer ic = CardContainer.Load(path);

        foreach (Card card in ic.cards)
        {
            print(card.name);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
