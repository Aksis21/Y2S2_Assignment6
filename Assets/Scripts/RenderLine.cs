using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderLine : MonoBehaviour
{
    LineRenderer lr;
    public List<Transform> points;
    public float renderDistance;
    Vector3 distance;

    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    void Update()
    {
        distance = points[0].position - points[1].position;
        if (distance.magnitude > renderDistance)
            lr.enabled = false;
        else lr.enabled = true;

        lr.SetPosition(0, points[0].position);
        lr.SetPosition(1, points[1].position);
    }
}
