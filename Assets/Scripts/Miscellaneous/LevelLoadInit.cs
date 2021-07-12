
using System.IO;

using UnityEngine;

public class LevelLoadInit : MonoBehaviour {

    public Transform player;

    private void Awake () {

        if (!Directory.Exists(Application.persistentDataPath + LevelLoadInfo.LevelPath))
            Directory.CreateDirectory(Application.persistentDataPath + LevelLoadInfo.LevelPath);

        string loadPath = Application.persistentDataPath + LevelLoadInfo.LevelPath;

        byte[] levelData = File.ReadAllBytes(loadPath);

        FindObjectOfType<LevelConstructor>().Construct(levelData);

        player.position = FindObjectOfType<StartPos>().transform.position;
    }
}
