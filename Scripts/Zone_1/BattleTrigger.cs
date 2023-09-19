using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleTrigger : MonoBehaviour
{
    public bool isDangerous;
    public string sceneName;
    
    public void LoadBattle()
    {
        if(isDangerous)
        {
            SceneManager.LoadScene(sceneName);            
        }
    }
}
