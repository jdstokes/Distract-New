using BrainVR.UnityFramework.Experiment;
using UnityEngine;

public class TestingFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)) ExperimentManager.Instance.StartExperiment();
    }
}
