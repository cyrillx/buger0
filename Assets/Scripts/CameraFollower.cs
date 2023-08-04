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
        // _target.position + _offset = _camera;
        ///_camera = GetComponent<Camera>().transform;
        _offset = _camera.position - _target.position;
    }

    private void Update()
    {
        
    }

    private void LateUpdate()
    {
        _camera.position = _target.position + _offset;
        
    }

    private void FixedUpdate()
    {
    }
}
