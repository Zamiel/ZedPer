using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DataEditorWindow : EditorWindow
{
    [MenuItem("ZedPer/Data Editor")]
    static void Init()
    {
        EditorWindow.GetWindow(typeof(DataEditorWindow));
    }

    private void Start()
    {

    }

    private void OnGUI()
    {
        
    }
}
