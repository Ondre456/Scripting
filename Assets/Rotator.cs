using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]private float Speed;

    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, Speed));
    }
}
