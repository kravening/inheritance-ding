using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour
{
	//protected int collectedCoins = 0;
    //functie is virtual zo dat die ge override kan worden
    public virtual void PlayerHit(Player _GO)// kan geinherit worden, let op "virtual"
    {
        //dit is de basis van de PlayerHit functie
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        var l_player = coll.gameObject.GetComponent<Player>();//check of de collider gameobject wel onze speler is
        if (l_player != null)//IS dit NIET null dan hebben we de collider van de speler
        {
            PlayerHit(l_player);
        }
		//Debug.Log(collectedCoins);
    }
}
