using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using SimpleJSON;
public class ShopLoad : MonoBehaviour
{
    public GameObject _itemPrefab;
    public GameObject _content;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetAllItems());
    }

    IEnumerator GetAllItems()
    {
        WWWForm getAllItemsForm = new WWWForm();
        UnityWebRequest getAllItemsRequest = UnityWebRequest.Post("http://localhost/shop/getall.php", getAllItemsForm);
        yield return getAllItemsRequest.SendWebRequest();
        if(getAllItemsRequest.error == null)
        {
            JSONNode allItems = JSON.Parse(getAllItemsRequest.downloadHandler.text);
            foreach(JSONNode item in allItems)
            {
                var shopItem = Instantiate(_itemPrefab, new Vector3(), Quaternion.identity);
                shopItem.transform.SetParent(_content.transform);
                shopItem.GetComponent<ItemRow>().name = item[1];
                shopItem.GetComponent<ItemRow>().price = item[2];
                shopItem.GetComponent<ItemRow>().amount = item[3];
                shopItem.GetComponent<ItemRow>().url = item[4];
                shopItem.GetComponent<ItemRow>().AssignValue();

            }
        }
        else
        {
            Debug.Log(getAllItemsRequest.error);
        }
    }
}
