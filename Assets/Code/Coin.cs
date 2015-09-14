using UnityEngine;
using System.Collections;

public class Coin : Pickup//inherit van pickup
{
    public override void PlayerHit(Player _GO)
    {
        base.PlayerHit(_GO);//roep de basis classe nog wel aan(dus de playerhit in pickup)
        //voeg hier code toe zo dat de speler zijn score omhoog gaat
		_GO.coinCollected ();
		Destroy (this.gameObject);
    }
}
