using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class NextLVL : MonoBehaviour
{
    public static int nextlvl = 1500;

    // Update is called once per frame
    void Update()
    {
        Text gt = GetComponent<Text>();
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("_Scene_0"))
        {
            gt.text = "For next level: " + nextlvl;
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("_Scene_1")) 
        {
            gt.text = "For next level: " + nextlvl;
        }

        if (nextlvl > PlayerPrefs.GetInt("NextLVL"))
            PlayerPrefs.SetInt("NextLVL", nextlvl);
    }
}
