using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeUI : MonoBehaviour
{
    public TextMeshProUGUI timeText;

    public WorldTime worldTime;

    void Start()
    {
        timeText = GetComponent<TextMeshProUGUI>();
        UpdateTime();
    }

    public void UpdateTime()
    {
        timeText.text = $"{worldTime.hour:00}:{worldTime.minute:00}";
    }
}
