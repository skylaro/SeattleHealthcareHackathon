using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[System.Serializable]
public class UserSaveData {

    private struct saveData
    {
        public int section;
        public bool passed;
    }

    private static List<saveData> saves = new List<saveData>();

	public static void save()
    {
        //saves.Add();
        BinaryFormatter f = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "");
    }
}
