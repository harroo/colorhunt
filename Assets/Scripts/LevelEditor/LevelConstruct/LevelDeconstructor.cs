
using UnityEngine;
using UnityEditor;

using UltimateSerializer;
using CompressionUtility;

public class LevelDeconstructor : MonoBehaviour {

    public byte[] Deconstruct () {

        Level level = LevelEditorCache.currentLevel;

        byte[] levelData = USerialization.Serialize(level);

        byte[] compressedOutput = GZipCompression.Compress(levelData);

        return compressedOutput;
    }
}
