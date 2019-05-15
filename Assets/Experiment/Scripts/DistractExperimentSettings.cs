using BrainVR.UnityFramework.Experiment;
using BrainVR.UnityFramework.Helpers;
using UnityEditor;
using UnityEngine;

public class DistractExperimentSettings : ExperimentSettings
{
    public Color DistractColor;
    public float TrialTime;
    public Color[] colors = {Color.red, Color.yellow, Color.red};


#if UNITY_EDITOR
    [MenuItem("Assets/BrainVR/DistractExperimentSettings")]
    public static void CreateDialogueLine()
    {
        ScriptableObjectUtility.CreateAsset<DistractExperimentSettings>();
    }
    [CustomEditor(typeof(DistractExperimentSettings))]
    public class SettingsEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            DistractExperimentSettings myScript = (DistractExperimentSettings)target;
            if (GUILayout.Button("Serialise settings")) Debug.Log(myScript.SerialiseOut());
        }
    }
#endif
}
