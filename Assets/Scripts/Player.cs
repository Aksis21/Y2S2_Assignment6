using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float HP = 10f;
    public float moveSpeed;
    public GameObject youDied;
    public Material playerMat;
    Rigidbody rb;
    Vector3 direction;
    Color lerpCol;
    float damageTime = float.PositiveInfinity;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        youDied.SetActive(false);
    }

    void Update()
    {
        damageTime += Time.deltaTime;
        lerpCol = Color.Lerp(Color.red, Color.white, damageTime);
        playerMat.color = lerpCol;

        if (HP <= 0f)
        {
            youDied.SetActive(true);
            Time.timeScale = 0f;
        }

        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = direction * moveSpeed;
    }

    public void takeDamage()
    {
        HP -= 1;
        damageTime = 0f;
    }
}
