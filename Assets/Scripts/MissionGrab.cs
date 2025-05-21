using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class MissionGrab : MonoBehaviour
{
    [SerializeField] private Missions missions;
    [SerializeField] private string grabTarget;

    private XRGrabInteractable interactable;

    private void Awake()
    {
        interactable = GetComponent<XRGrabInteractable>();
    }

    private void OnEnable()
    {
        interactable.selectEntered.AddListener(Grab);
    }

    private void OnDisable()
    {
        interactable.selectEntered.RemoveListener(Grab);
    }

    private void Grab(SelectEnterEventArgs args)
    {
        missions.ActionMission(StepAction.Grab, grabTarget);
    }
}
