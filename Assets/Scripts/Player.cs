using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    Rigidbody rb;
    Vector3 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = direction * moveSpeed;
    }
}
