using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _ball;

    [SerializeField]
    private float _ballGenerateHeight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(_ball, new Vector3(Random.Range(-1.4f, 1.4f), transform.position.y, 0), Quaternion.identity);
        }
    }
}
