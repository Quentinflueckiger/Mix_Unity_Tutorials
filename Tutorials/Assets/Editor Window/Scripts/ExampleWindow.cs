using UnityEngine;
using UnityEditor;
using System;

public class ExampleWindow : EditorWindow {

    Color color;

    [MenuItem("Window/Colorizer")]
    public static void ShowWindow()
    {
        GetWindow<ExampleWindow>("Colorizer");
    }

    private void OnGUI()
    {
        GUILayout.Label("Color the selected objects !", EditorStyles.boldLabel);

        color = EditorGUILayout.ColorField("Color", color);

        if(GUILayout.Button("Colorizer"))
        {

            Colorize();
            
        }
    }

    private void Colorize()
    {
        foreach (GameObject obj in Selection.gameObjects)
        {
            Renderer renderer = obj.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.sharedMaterial.color = color;
            }
        }
    }
}
