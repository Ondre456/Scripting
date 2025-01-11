using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float Speed;

    void FixedUpdate()
    {
        Vector3 moveDirection = transform.right;

        transform.position += moveDirection * Speed * Time.deltaTime;
    }
}
