using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Missions : MonoBehaviour
{
    [SerializeField] private MissionsData missionData;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _completeClip;
    [SerializeField] private AudioClip _errorClip;
    [SerializeField] private UnityEvent onMissionComplete;
    [SerializeField] private Toggle[] _toogle;
        
    private int _currentStep;
    private bool _isActive = true;


    public void StartMission()
    {
        _currentStep = 0;
        _isActive = true;
    }

    public void ActionMission(StepAction action, string target)
    {
        var step = missionData.Steps[_currentStep];

        if(step.stepAction != action || step.Target != target)
        {
            step.status = StepStatus.CompetedError;
            _audioSource.PlayOneShot(_errorClip);
        }
        else
        {
            step.status = StepStatus.CompletedCorrect;
            _audioSource.PlayOneShot(_completeClip);
            _toogle[_currentStep].isOn = true;
            _currentStep++;
        }

        if(_currentStep >= missionData.Steps.Length)
        {
            MissionsFinish();
        }
    }

    private void MissionsFinish()
    {
        _isActive = false;
        onMissionComplete.Invoke();
    }
}
