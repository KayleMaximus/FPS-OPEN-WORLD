using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SniperAmmo : AmmoType
{
    private void Start()
    {
        _ammoAmount = 30;
    }

    protected internal override int GetCurrentAmmo()
    {
        return this._ammoAmount;
    }

    protected internal override void ReduceCurrentAmmo()
    {
        _ammoAmount--;
    }

    protected internal override void IncreaseCurrentAmmo(int ammountPickups)
    {
        _ammoAmount += ammountPickups;
    }

    protected override void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            string ammoType = "SniperBullet(Clone)";
            if (gameObject.name == ammoType)
            {
                IncreaseCurrentAmmo(15);
                Debug.Log("Dan da tangggggggggggggggggggggggggggggggggggggggggggggg");
                Destroy(gameObject);
            }            
        }
    }


}
