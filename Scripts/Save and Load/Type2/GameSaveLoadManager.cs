using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameSaveLoadManager : MonoBehaviour
{
    public List<ScriptableObject> objects = new List<ScriptableObject>();

    public void SaveScriptable()
    {
        for (int i = 0; i < objects.Count; i++)
        {
            FileStream file = File.Create(Application.dataPath + "/Saves/Slot1" + string.Format("/{0}.dat", i));
            BinaryFormatter binary = new BinaryFormatter();

            var json = JsonUtility.ToJson(objects[i]);

            binary.Serialize(file, json);
            file.Close();
        }
    }

    public void LoadScriptable()
    {
        for (int i = 0; i < objects.Count; i++)
        {
            if(File.Exists(Application.dataPath + "/Saves/Slot1" + string.Format("/{0}.dat", i)))
            {
                FileStream file = File.Open(Application.dataPath + "/Saves/Slot1" + string.Format("/{0}.dat", i), FileMode.Open);
                BinaryFormatter binary = new BinaryFormatter();
                JsonUtility.FromJsonOverwrite((string)binary.Deserialize(file), objects[i]);
                file.Close();
            }
        }
    }
}
