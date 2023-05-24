using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class GetTest : MonoBehaviour
{

    public Text text;
    
    void Start()
    {
        StartCoroutine(GetTesting());
    }

    IEnumerator GetTesting()
    {
        UnityWebRequest webRequest = UnityWebRequest.Get("http://localhost/test.php");
        yield return webRequest.SendWebRequest();
        text.text = webRequest.downloadHandler.text;
    }

}
