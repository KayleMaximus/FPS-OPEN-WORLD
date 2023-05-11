using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    [SerializeField]
    private Animator _transition = null;

    public float _transitionTime = 1f;

    private void Update()
    {
        if(SceneManager.GetActiveScene().name == "Lobby" && Input.GetKeyDown(KeyCode.Escape))
        {
            LoadSelectedLevel("MainMenu");
        }
    }

    public void PlayGain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void BackToLobby()
    {
        LoadSelectedLevel("Lobby");
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        //play animation
        _transition.SetTrigger("Start");
        //wait
        yield return new WaitForSeconds(_transitionTime);
        //loadscene
        SceneManager.LoadScene(levelIndex);
    }  
    
    IEnumerator LoadSelectLevel(string levelName)
    {
        //play animation
        _transition.SetTrigger("Start");
        //wait
        yield return new WaitForSeconds(_transitionTime);
        //loadscene
        SceneManager.LoadScene(levelName);
    }

    public void LoadSelectedLevel(string levelName)
    {
        StartCoroutine(LoadSelectLevel(levelName));
    }
}
