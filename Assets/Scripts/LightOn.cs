using UnityEngine;

public class LightOn : MonoBehaviour
{
    [SerializeField] private Light _directionLight;
    [SerializeField] private float _targetIntencity;
    [SerializeField] private float _fadeDuration;

    private float _timer;

    private void Start()
    {
        _directionLight.intensity = 0;
    }

    private void Update()
    {
        if(_timer <= _fadeDuration)
        {
            _timer += Time.deltaTime;
            float t = _timer / _fadeDuration;
            _directionLight.intensity = Mathf.Lerp(0, _targetIntencity, t);
        }
    }
}
