using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour
{
    private Vector3 _newPosition;
    
    void FixedUpdate()
    {
        _newPosition = transform.position;
        _newPosition.z += Mathf.Sin(Time.time) * Time.deltaTime;
        transform.position = _newPosition;
    }
}
