using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    //Attribute
    public int id;
    public string itemName, amount, price, url;

    [SerializeField]
    private Image _thisRenderer;
    [SerializeField]
    public TMP_Text _amountText;
    public void AssignValue()
    {
        _amountText.text = "x" + amount;
        StartCoroutine(LoadImageFromUrl());
    }

    private IEnumerator LoadImageFromUrl()
    {
        WWW wwwLoader = new WWW(url);
        yield return wwwLoader;
        _thisRenderer.sprite = Sprite.Create(wwwLoader.texture, new Rect(0, 0, wwwLoader.texture.width, wwwLoader.texture.height), Vector2.one / 2);
    }
}
