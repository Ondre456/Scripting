using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAroundY : MonoBehaviour
{
    [SerializeField]private float RotationSpeed;

    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0,RotationSpeed));
    }
}
