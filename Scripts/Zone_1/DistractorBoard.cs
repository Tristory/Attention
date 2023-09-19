using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Reflection;

public class DistractorBoard : MonoBehaviour
{
    [Header("Player")]
    public PlayerStatus playerStatus;
    
    [Header("Distractor")]
    public PropertyD distractor;

    [Header("Board")]
    public TextMeshProUGUI nameField;
    public TextMeshProUGUI focusText;
    public Image distractorSprite;

    void Start()
    {
        TextUpdate();
        nameField.text = distractor.dA.dName;
        distractorSprite.sprite = distractor.sprite;
    }
    
    public void TextUpdate()
    {
        focusText.text = $"{distractor.dA.focusValue}";
    }

    /*public void IncreaseFocusValue()
    {
        distractor.da.focusValue += 10;
        TextUpdate();
    }*/

    public void CollectAttention()
    {
        playerStatus.attention += distractor.dA.focusValue;
        distractor.dA.focusValue = 0;

        TextUpdate();
    }

    public void LevelUp()
    {
        distractor.LevelUp();
    }
}
