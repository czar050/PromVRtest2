using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] private float _roateSpeed;

    private void Update()
    {
        transform.Rotate(Vector3.forward * _roateSpeed * Time.deltaTime);
    }
}
