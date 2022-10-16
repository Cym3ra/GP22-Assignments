using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMotion : ProcessingLite.GP21
{
    Vector2 circlePos;
    Vector2 squarePos;
    float diameter = 2;
    float velocity = 10f;
    float friction = 0.9f;
    float maxSpeed = 30f;
    float acceleration = 2f;
   

    void Start()
    {
        // Set start position of circle and square
        circlePos = new Vector2(Width / 2, Height / 2); //middle of the screen
        squarePos = new Vector2(Width - 2, Height - 2);
        Stroke(164,210,72);
    }

    void Update()
    {
        Background(152, 190, 100);

        //Movement input
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector2 circleMovement = new Vector2(horizontalInput, verticalInput).normalized;

        // Add movement and speed for circle and square 
        circlePos += circleMovement * velocity * Time.deltaTime;
        squarePos += circleMovement * velocity * acceleration * Time.deltaTime;

        // If no key is pressed, add friction to deaccelerate
        if(circleMovement == Vector2.zero)
        {
            velocity *= friction - Time.deltaTime;
        }
        else
        {
            velocity += acceleration * Time.deltaTime;
        }
        
        if (acceleration > maxSpeed)
        {
            acceleration = Mathf.Clamp(acceleration, 0, maxSpeed);
        }

        // Draw a circle and a square
        Fill(233, 236, 149);
        Circle(circlePos.x, circlePos.y, diameter);
        Fill(222, 112, 123);
        Square(squarePos.x, squarePos.y, diameter);
    }
}
