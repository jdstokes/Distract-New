using BrainVR.UnityFramework.Experiment;
using UnityEngine;
public class DistractExperiment : BaseExperiment
{
    private DistractExperimentSettings Settings;

    private Color _currentColor;

    public override void AddSettings(ExperimentSettings settings)
    {
        Settings = (DistractExperimentSettings)settings;
    }
    public override string ExperimentHeaderLog()
    {
        return "Time; Trial; sound";
    }
    protected override bool CheckForEnd()
    {
        return TrialNumber > Settings.colors.Length;
    }

    protected override void OnExperimentInitialise()
    {
        Debug.Log("Hello, I ma initialising");
    }
    protected override void AfterExperimentSetup()
    {
        Debug.Log("Hi, I ma being setup");
        SetupTrial();
    }

    protected override void OnTrialSetup()
    {
        _currentColor = Settings.colors[TrialNumber];
    }

    protected override void AfterTrialSetup()
    {
        StartTrial();
    }
}
