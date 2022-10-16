using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : ProcessingLite.GP21
{
    public Vector2 circlePos;
    public float diameter = 2;
    public float velocity = 10f;

    public Player()
    {
        // Set start position of circle
        circlePos = new Vector2(Width / 2, Height / 2); //middle of the screen
        Stroke(164, 210, 72);
    }

    public void DrawPlayer()
    {
        // Draw a circle
        Fill(233, 236, 149);
        Circle(circlePos.x, circlePos.y, diameter);
    }

    public void PlayerMovement()
    {
        //Movement input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 circleMovement = new Vector2(horizontalInput, verticalInput);

        // Add movement and speed for circle
        circlePos += circleMovement * velocity * Time.deltaTime;
    }
}
