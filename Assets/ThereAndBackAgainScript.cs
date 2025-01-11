using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThereAndBackAgainScript : MonoBehaviour
{
    [SerializeField] private float RunningSpeed;
    [SerializeField] private GameObject FirstPoint;
    [SerializeField] private GameObject LastPoint;

    private GameObject _currentGoal;

    void Start()
    {
        _currentGoal = FirstPoint;
    }


    void Update()
    {
        if (transform.position == _currentGoal.transform.position)
        {
            if (_currentGoal == FirstPoint)
                _currentGoal = LastPoint;
            else
                _currentGoal = FirstPoint;
        }

        transform.position = Vector3.MoveTowards(transform.position, _currentGoal.transform.position, RunningSpeed);
    }
}
