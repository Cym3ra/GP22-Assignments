using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment : ProcessingLite.GP21
{
    public float x = 5f;
    public float y = 4f;
    public float diameter = 6f;

    private void Start()
    {
        // adds hi
        /*Line(4, 7, 5, 3);
        Line(4, 5, 6, 5);
        Line(6, 7, 6, 3);

        Line(8, 5.5f, 8, 3);
        Line(8, 7, 8, 6.8f);*/

        // adds a blue circle
        Fill(30, 123, 152);
        Circle(x, y, diameter);

    }

    void Update()
    {

        // adds CK in bold, green letters
        StrokeWeight(4);
        Stroke(169, 219, 82);
        Line(4, 5, 4, 3);
        Line(4, 5, 5, 5);
        Line(4, 3, 5, 3);

        Line(6, 5, 6, 3);
        Line(6, 4, 7, 5);
        Line(6, 4, 7, 3);

        //Background(0); //Clears the background and sets the color to 0(black)

        //Circle(x, y, diameter); //Draws a circle on screen.
    }
}
