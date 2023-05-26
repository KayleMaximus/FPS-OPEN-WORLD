using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;

public class ItemRow : MonoBehaviour
{
    [SerializeField] 
    private TMP_Text _name, _amount, _price, _quantity;
    [SerializeField]
    public Image thisRenderer;
    [SerializeField]
    public string _url;

    public string itemName, amount, price, url;

    public double _total;

    UIManager _uiManager;

    private void Start()
    {
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();

        if ( _uiManager == null )
        {
            Debug.LogError("The UI Manager is NULL.");
        }
    }
    public void AssignValue()
    {
        _name.text = itemName;
        _amount.text = amount;
        _price.text = "$" + price;
        _url = url;
        StartCoroutine(LoadImageFromUrl());
    }

    private IEnumerator LoadImageFromUrl()
    {
        WWW wwwLoader = new WWW(_url);
        yield return wwwLoader;

        thisRenderer.sprite = Sprite.Create(wwwLoader.texture, new Rect(0, 0, wwwLoader.texture.width, wwwLoader.texture.height), Vector2.one / 2);
       // thisRenderer.sprite = Sprite.Create(wwwLoader.texture, new Rect(0, 0, 0.5f,0.5f), Vector2.one /2);
    }

    public void Add()
    {
        if (_quantity.text == _amount.text)
        {
            return;
        }
        _quantity.text = (Int32.Parse(_quantity.text) + 1).ToString();
        _total += 1000f;
        _uiManager.UpdateTotalMoney(_total);
    }

    public void Minus()
    {
        if (_quantity.text == "0")
        {
            return;
        }
        _quantity.text = (Int32.Parse(_quantity.text) - 1).ToString();
        _total -= 1000f;
        _uiManager.UpdateTotalMoney(_total);
    }
}
