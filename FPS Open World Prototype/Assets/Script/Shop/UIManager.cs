using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _total;
    // Start is called before the first frame update
    void Start()
    {
        _total.text = "$" + 0;
    }

    public void UpdateTotalMoney(double total)
    {
        _total.text = "$" + total.ToString();
    }
}
