using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class ItemRow : MonoBehaviour
{
    [SerializeField] 
    private TMP_Text _name, _amount, _price;
    [SerializeField]
    public Image thisRenderer;
    [SerializeField]
    public string _url ;

    public string itemName, amount, price, url;

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

    public void Clickec()
    {
        Debug.Log("Clicked");
    }
}
