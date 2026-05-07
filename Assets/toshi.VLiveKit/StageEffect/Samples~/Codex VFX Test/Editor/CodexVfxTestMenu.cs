using UnityEditor;
using UnityEngine;

public static class CodexVfxTestMenu
{
    private const string PrefabGuid = "63dfff70a4c5446cbb074956f4df1b42";

    [MenuItem("toshi/Codex/VFX Test/Place Spark Fountain In Scene")]
    private static void PlaceSparkFountainInScene()
    {
        var prefabPath = AssetDatabase.GUIDToAssetPath(PrefabGuid);
        var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(prefabPath);
        if (prefab == null)
        {
            Debug.LogError("Missing Codex Spark Fountain VFX test prefab.");
            return;
        }

        var instance = (GameObject)PrefabUtility.InstantiatePrefab(prefab);
        Undo.RegisterCreatedObjectUndo(instance, "Place Codex Spark Fountain");
        instance.transform.position = Vector3.zero;
        Selection.activeGameObject = instance;
    }
}
