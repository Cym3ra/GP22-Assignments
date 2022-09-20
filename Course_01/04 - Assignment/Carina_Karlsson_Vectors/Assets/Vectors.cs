using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectors : ProcessingLite.GP21
{
    public Vector2 circlePosition, mousePos, moveDirection;
    public float diameter = 2f;
    private float speed = 2f;

    private void Start()
    {
        Stroke(168, 226, 106);
        StrokeWeight(1.5f);
        Fill(16, 111, 137);
    }

    void Update()
    {
        Background(0);
        mousePos = new Vector2(MouseX, MouseY);
        Circle(circlePosition.x, circlePosition.y, diameter);

        if (Input.GetMouseButtonDown(0))
        {
            // move the circle to the mouse position
            circlePosition.x = MouseX;
            circlePosition.y = MouseY;
        }

        if (Input.GetMouseButton(0))
        {
            // make a line from the circle to the mouse 
            Line(circlePosition.x, circlePosition.y, MouseX, MouseY);
        }

        if (Input.GetMouseButtonUp(0))
        {
            moveDirection = (mousePos - circlePosition) * speed * Time.deltaTime; // Calculate movement 
        }

        // makes the circle bounce of the edges of the screen 
        if (circlePosition.x + 1 > Width || circlePosition.x - 1 < 0)
        {
            moveDirection.x *= - 1;
        }       
        if(circlePosition.y + 1 > Height || circlePosition.y - 1 < 0)
        {
            moveDirection.y *= - 1;
        }

        // Make the circle move when holding down the mousebutton 
        circlePosition = circlePosition + moveDirection;
    }
}
