using UnityEngine;

public class MissionPut : MonoBehaviour
{
    [SerializeField] private Missions missions;
    [SerializeField] private string putTarget;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Cube"))
        {
            missions.ActionMission(StepAction.Put, putTarget);
        }
    }
}
