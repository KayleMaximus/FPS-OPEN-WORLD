
using Unity.VisualScripting;
using UnityEngine;

public abstract class AmmoType : MonoBehaviour
{
    protected internal string _ammoName;
    protected internal int _ammoAmount;

    protected internal abstract int GetCurrentAmmo();
    protected internal abstract void ReduceCurrentAmmo();
    protected internal abstract void IncreaseCurrentAmmo(int ammountPickups);
    protected abstract void OnTriggerEnter(Collider other);
}