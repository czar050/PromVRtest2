using UnityEngine;

public class MissionCheckPoint : MonoBehaviour
{
    [SerializeField] private Missions missions;
    [SerializeField] private string triggerTarget;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            missions.ActionMission(StepAction.CheckPoint, triggerTarget);
            Destroy(gameObject);
        }
    }
}
