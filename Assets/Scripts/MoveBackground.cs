using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    public float ScrollSpeed = -5f;

    private Vector2 StartPos;
    // Use this for initialization
    void Start()
    {
        StartPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float NewPos = Mathf.Repeat(Time.time * ScrollSpeed, 18);
        transform.position = StartPos + Vector2.up * NewPos;
    }
}
