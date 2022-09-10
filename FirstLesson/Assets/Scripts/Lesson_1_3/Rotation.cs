using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _transform;

    private void Start()
    {
        _transform = gameObject.transform;
    }
    private void Update()
    {
        _transform.Rotate(new Vector3(0, Time.deltaTime * _speed, 0));
    }
}
