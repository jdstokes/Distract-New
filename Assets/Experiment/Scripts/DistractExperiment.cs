using BrainVR.UnityFramework.Experiment;
using UnityEngine;
public class DistractExperiment : BaseExperiment
{
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
        return TrialNumber > 4;
    }

    protected override void OnExperimentInitialise()
    {
        Debug.Log("Experiment is initialised");
    }
}
