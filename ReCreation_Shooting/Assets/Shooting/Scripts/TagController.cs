using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TagController : MonoBehaviour {
    void Start()
    {
        AddTag(StringController.Name.Enemy1);
        AddTag(StringController.Name.Enemy2);
        AddTag(StringController.Name.Enemy3);
        AddTag(StringController.Name.Enemy4);
        AddTag(StringController.Name.Enemy5);
    }

    static void AddTag(string tagname)
    {
        UnityEngine.Object[] asset = AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/TagManager.asset");
        if ((asset != null) && (asset.Length > 0))
        {
            SerializedObject so = new SerializedObject(asset[0]);
            SerializedProperty tags = so.FindProperty("tags");

            for (int i = 0; i < tags.arraySize; ++i)
            {
                if (tags.GetArrayElementAtIndex(i).stringValue == tagname)
                {
                    return;
                }
            }

            int index = tags.arraySize;
            tags.InsertArrayElementAtIndex(index);
            tags.GetArrayElementAtIndex(index).stringValue = tagname;
            so.ApplyModifiedProperties();
            so.Update();
        }
    }
}
