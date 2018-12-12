using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    public float scrollSpeed = -5f;
    public float tileSizeZ = 25f;

    private Vector3 startPosition;
    // Use this for initialization
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //float NewPos = Mathf.Repeat(Time.time * scrollSpeed, 18);
        //transform.position = startPosition + Vector3.up * NewPos;
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
        transform.position = startPosition + Vector3.up * newPosition;
    }
}
