using UnityEngine;

[CreateAssetMenu(fileName = "Mission", menuName = "Mission")]
public class MissionsData : ScriptableObject
{
    public MissionStep[] Steps;
}
