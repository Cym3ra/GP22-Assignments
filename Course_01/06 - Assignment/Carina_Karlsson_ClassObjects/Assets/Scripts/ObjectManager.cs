using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : ProcessingLite.GP21
{
    //Ball myball;
    Ball[] balls;
    Player player;
    int numberOfBalls = 10;
    bool isAlive = true;

    void Start()
    {
        //myball = new Ball(5, 5);
        balls = new Ball[numberOfBalls];

        player = new Player();

        //A loop that can be used for creating multiple balls.
        for (int i = 0; i < balls.Length; i++)
        {
            //Add some code for creating balls here.
            balls[i] = new Ball(5, 5);
        }
    }

    void Update()
    {

        if (isAlive)
        {
            Background(0);
            //Tell each ball to update it's position
            for (int i = 0; i < balls.Length; i++)
            {
                balls[i].UpdatePos();
                balls[i].Draw();
                balls[i].EdgeCollision();
                if (CircleCollision(balls[i], player))
                {
                    isAlive = false;
                }
            }

            player.DrawPlayer();
            player.PlayerMovement();
        }
        else if (!isAlive)
        {
            Background(255);
            Stroke(156, 16, 16);
            Fill(156, 16, 16);
            TextSize(160);
            Text("GAME OVER", Width/2, Height/2);
        }
    }

    bool CircleCollision(Ball ball, Player player)
    {
        float maxDistance = ball.diameter/2 + player.diameter/2;

        //first a quick check to see if we are too far away in x or y direction
        //if we are far away we don't collide so just return false and be done.
        if (Mathf.Abs(ball.position.x - player.circlePos.x) > maxDistance || Mathf.Abs(ball.position.y - player.circlePos.y) > maxDistance)
        {
            return false;
        }
        //we then run the slower distance calculation
        //Distance uses Pythagoras to get exact distance, if we still are to far away we are not colliding.
        else if (Vector2.Distance(new Vector2(ball.position.x, ball.position.y), new Vector2(player.circlePos.x, player.circlePos.y)) > maxDistance)
        {
            return false;
        }
        //We now know the points are closer then the distance so we are colliding!
        else
        {
            return true;
        }
    }
}
