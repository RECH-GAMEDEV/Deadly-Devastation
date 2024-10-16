using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyTransition;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroWait : MonoBehaviour
{
    public DemoLoadScene loadScene;
    public float waitTime;
    void Start()
    {
        StartCoroutine(WaitForLevel());
    }
    IEnumerator WaitForLevel()
    {
        yield return new WaitForSeconds(waitTime);
        if (PlayerPrefs.GetInt("isFirstRun", 0) == 0)
        {
            PlayerPrefs.SetInt("isFirstRun", 1);
            SceneManager.LoadScene("IsFirstGameOpenScene");
        }
        else
        {
            loadScene.LoadScene("IsMenuScene");
        }


    }
}
