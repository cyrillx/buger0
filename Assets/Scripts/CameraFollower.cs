using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Transform _camera;

    private Vector3 _offset;

    private void Start()
    {
        _offset = _camera.position - _target.position;
    }

    private void LateUpdate()
    {
        _camera.position = _target.position + _offset;
    }
}
