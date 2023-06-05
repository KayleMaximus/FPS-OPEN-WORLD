using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TommyAmmo : AmmoType
{
    Weapon weapon;
    private void Start()
    {
        weapon = GetComponent<Weapon>();
        _ammoAmount = 50;
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
            string ammoType = "TommyBullet(Clone)";
            if (gameObject.name == ammoType)
            {
                //IncreaseCurrentAmmo(15);
                //weapon._ammoText.SetText(_ammoAmount.ToString());
                Destroy(gameObject);
            }
                Debug.Log("Dan da tangggggggggggggggggggggggggggggggggggggggggggggg");
        }
    }




}
