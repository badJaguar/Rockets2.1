using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDirection : MonoBehaviour
{
    Rigidbody2D rb = new Rigidbody2D();

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) || Input.GetAxis("Mouse X") < 0 && Input.GetAxis("Mouse X") > 0)
        {
            // get mouse position in screen space
            // (if touch, gets average of all touches)
            Vector2 screenPos = Input.mousePosition;
            // set a distance from the camera
            screenPos.y = 0f;
            // convert mouse position to world space
            Vector2 worldPos = Camera.main.ScreenToWorldPoint(screenPos);

            // get current position of this GameObject
            Vector2 newPos = transform.position;
            // set x position to mouse world-space x position
            newPos.x = worldPos.x;
            // apply new position
            transform.position = newPos;
        }
    }
}
