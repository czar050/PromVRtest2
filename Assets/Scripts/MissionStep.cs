
public enum StepAction { CheckPoint, Garb, Put}
public enum StepStatus { NotStarted, Skipped, CompetedError, CompletedCorrect}

[System.Serializable]
public class MissionStep
{
    public int ID;
    public StepAction stepAction;
    public StepStatus status = StepStatus.NotStarted;
    public string Target;
    public string Description;
}

