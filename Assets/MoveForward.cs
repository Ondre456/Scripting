using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float MoveSpeed;

    void FixedUpdate()
    {
        Vector3 moveDirection = transform.right;

        transform.position += moveDirection * MoveSpeed * Time.deltaTime;
    }
}
