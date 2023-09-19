using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class BattleResult : MonoBehaviour
{
    [Header("Configure")]
    public string sceneName;

    public PlayerStatus playerStatus;

    [Header("Reward")]
    public int focusPoint;

    [Header("Board element")]
    public TextMeshProUGUI _focusPoint;

    void Update()
    {
        BoardUpdate();
    }

    void BoardUpdate()
    {
        _focusPoint.text = $"{focusPoint:0}";
    }

    public void LoadNormal()
    {
        SceneManager.LoadScene(sceneName);

        //Add attention
        playerStatus.attention += focusPoint;
    }
}
