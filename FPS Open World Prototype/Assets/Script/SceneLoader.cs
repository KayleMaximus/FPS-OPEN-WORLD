using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    public void PlayGain()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Debug.Log("HIT2");
        Application.Quit();
    }
}
