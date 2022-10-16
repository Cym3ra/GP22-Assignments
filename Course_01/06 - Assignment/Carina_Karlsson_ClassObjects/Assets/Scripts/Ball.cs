using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Ball : ProcessingLite.GP21
{
    //Our class variables
    public Vector2 position; //Ball position
    Vector2 velocity; //Ball direction
    public float diameter = 1.3f;
    public int r, g, b;


    //Ball Constructor, called when we type new Ball(x, y);
    public Ball(float x, float y)
    {
        //Set our position when we create the code.
        position = new Vector2(x, y);

        //Create the velocity vector and give it a random direction.
        velocity = new Vector2();
        velocity.x = Random.Range(0, 11) - 5;
        velocity.y = Random.Range(0, 11) - 5;

        r = Random.Range(0, 255);
        g = Random.Range(0, 255);
        b = Random.Range(0, 255);
    }

    //Draw our ball
    public void Draw()
    {
        Fill(r, g, b);
        Circle(position.x, position.y, diameter);
    }
        //Update our ball
    public void UpdatePos()
    {
        position += velocity * Time.deltaTime;
    }

    public void EdgeCollision()
    {
        if (position.x + diameter / 2 > Width|| position.x - diameter / 2 < 0)
        {
            velocity.x *= -1;
        }
        if (position.y + diameter / 2  > Height|| position.y - diameter / 2 < 0)
        {
            velocity.y *= -1;
        }
    }
}
