using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class AmmoFactory : MonoBehaviour
{
    [SerializeField] GameObject _sniperAmmo;
    public GameObject CreateRandomAmmo(Vector3 position)
    {
        int randomIndex = Random.Range(1, 4);
        GameObject ammoModel = null; 

        switch (randomIndex)
        {
            case 1:
                ammoModel = _sniperAmmo;
                break;
            case 2:
                ammoModel = _sniperAmmo; 
                break;
            case 3:
                ammoModel = _sniperAmmo;
                break;
            default:
                return null;
        }
        if (ammoModel != null)
        {
            GameObject ammoObject = Instantiate(ammoModel, position, Quaternion.identity);
            return ammoObject;
        }
        return null;
    }
}
