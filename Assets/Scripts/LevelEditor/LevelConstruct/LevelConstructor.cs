
using UnityEngine;
using UnityEditor;

using UltimateSerializer;
using CompressionUtility;

public class LevelConstructor : MonoBehaviour {

    private void Start () {

        LevelEditorCache.currentLevel = new Level();

        LevelEditorCache.objectCache.Clear();
    }

    public void Construct (byte[] input) {

        byte[] decompressedInput = GZipCompression.Decompress(input);

        Level level = (Level)USerialization.Deserialize<Level>(decompressedInput);

        if (level.elements.Count > 1000) {

            if (!EditorUtility.DisplayDialog(
                "Exceedingly Large Level!",
                "This Level contains '" + level.elements.Count.ToString() + "' Elements.\nAre you sure you want to load it?",
                "Yes.", "No.")
            ) return;
        }

        foreach (var go in LevelEditorCache.objectCache) {

            Destroy(go);
        }
        LevelEditorCache.objectCache.Clear();

        foreach (var element in level.elements) {

            GameObject go = Instantiate(
                ElementTypes.instance.types[element.type],
                new Vector3(element.position_X, element.position_Y, 0),
                Quaternion.identity
            );

            go.transform.localScale = new Vector3(element.scale_X, element.scale_Y, 1);

            go.name = "Level Element";

            LevelEditorCache.objectCache.Add(go);
        }

        LevelEditorCache.currentLevel = level;
    }
}
