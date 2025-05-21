using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeLevell : MonoBehaviour
{
    [SerializeField] private Button _startButton;
    [SerializeField] private int _levelIndex;

    private void Start()
    {
        _startButton.onClick.AddListener(NextLevel);
    }

    private void NextLevel()
    {
        SceneManager.LoadScene(_levelIndex);
    }
}
