using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


public class PostTest : MonoBehaviour
{
    public TMP_InputField _inputField;
    public Text _textResult;
     
    public void Button()
    {
        StartCoroutine(Post());
    }

    IEnumerator Post()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", _inputField.text);
        UnityWebRequest postTest = UnityWebRequest.Post("http://localhost/posttest.php", form);
        yield return postTest.SendWebRequest();
        _textResult.text = postTest.downloadHandler.text;
    }
}
