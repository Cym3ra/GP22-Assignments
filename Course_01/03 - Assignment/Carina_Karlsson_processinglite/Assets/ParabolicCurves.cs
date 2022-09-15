using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParabolicCurves : ProcessingLite.GP21
{
    public float spaceBetweenLines = 0.2f;

    void Start()
    {
        Application.targetFrameRate = 5;
    }

    void Update()
    {
        StrokeWeight(0.3f);

        // Parabolic curves
        /*Line(0, 10, 1, 0);
        Line(0, 9, 2, 0);
        Line(0, 8, 3, 0);
        Line(0, 7, 4, 0);
        Line(0, 6, 5, 0);
        Line(0, 5, 6, 0);
        Line(0, 4, 7, 0);
        Line(0, 3, 8, 0);
        Line(0, 2, 9, 0);
        Line(0, 1, 10, 0);*/

        // make parabolic curves with a loop
        /*for (int i = 0; i < 11; i++)
        {
            Line(0, 10 - 1, i, 0);
        }*/

        // make parabolic curves with  every 3rd shifting color 
        spaceBetweenLines = Mathf.Sin(Time.time) + 1.2f;
        spaceBetweenLines *= 0.2f;

        for (int i = 0; i < Height / spaceBetweenLines; i++)
        {
            if (i % 3 == 0)
            {
                int r = Random.Range(0, 255);
                int g = Random.Range(0, 255);
                int b = Random.Range(0, 255);
                Stroke(r, g, b);
            }
            else
            {
                Stroke(255);
            }
            Line(0, Height - i * spaceBetweenLines, (Width * i) / (Height / spaceBetweenLines), 0);
        }
    }
}
