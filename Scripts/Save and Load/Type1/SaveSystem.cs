using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveSystem : MonoBehaviour
{
    public PlayerStatus playerStatus;

    public void SaveGame()
    {
        PlayerModel data = new PlayerModel();
        data.attention = playerStatus.attention;

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.dataPath + "/Save" + "/savemodel.json", json);
    }

    public void LoadGame()
    {
        string json = File.ReadAllText(Application.dataPath + "/Save" + "/savemodel.json");

        PlayerModel data = JsonUtility.FromJson<PlayerModel>(json);

        playerStatus.attention = data.attention;
    }

}
