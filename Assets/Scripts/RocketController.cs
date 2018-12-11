using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.UIElements;

public class RocketController : MonoBehaviour
{
    public float force = 5f;
    public float rotateSpeed = 1f;
    private Rigidbody2D player;
    public float moveSpeed = 50f;

    // Use this for initialization
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        var jetpackActive = Input.GetMouseButton(0);

        //if (jetpackActive)
        //{
        //    player.AddForce(new Vector2(0, force));
        //}
        if (Input.GetAxis("Mouse X") < 0 && jetpackActive)
        {
            player.AddForce(new Vector2(-moveSpeed, 0));
            //player.transform.localPosition += Vector3.left * Time.deltaTime * moveSpeed;
            //player.transform.position += new Vector3(Input.GetAxis("Mouse X") * Time.deltaTime * moveSpeed, 0.0f);
            //transform.Rotate(0, 0, -(Input.GetAxis("Mouse X")) * Time.deltaTime * rotateSpeed);

        }

        if (Input.GetAxis("Mouse X") > 0 && jetpackActive)
        {
            player.AddForce(new Vector2(moveSpeed, 0));
            //player.transform.localPosition += Vector3.right * Time.deltaTime * moveSpeed;

            //player.transform.position += new Vector3(Input.GetAxis("Mouse X") * Time.deltaTime * moveSpeed, 0.0f);
            //transform.Rotate(0, 0, -(Input.GetAxis("Mouse X")) * Time.deltaTime * rotateSpeed);
        }
        else if (!jetpackActive)
        {
            player.Sleep();
        }
    }
}
