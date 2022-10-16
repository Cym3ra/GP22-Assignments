using System.Collections.Generic;
using UnityEngine;

class CarKar : IRandomWalker
{
	//Add your own variables here.
	//Do not use processing variables like width or height

	int areaHeight, areaWidth;
	Vector2 playerPos;

	List<Vector2> pastPositions = new List<Vector2>();
	List<Vector2> possibleDirections = new List<Vector2> { new Vector2(0, 1), new Vector2(-1, 0), new Vector2(1, 0), new Vector2(0, -1) };

	public string GetName()
	{
		return "Carina"; //When asked, tell them our walkers name
	}

	public Vector2 GetStartPosition(int playAreaWidth, int playAreaHeight)
	{
		//Select a starting position or use a random one.
		float x = playAreaWidth /4;
		float y = playAreaHeight /3;

		areaHeight = playAreaHeight;
		areaWidth = playAreaWidth;

		playerPos = new Vector2(x, y);
		//a PVector holds floats but make sure its whole numbers that are returned!
		return new Vector2(x, y);
	}

	public Vector2 Movement()
	{
		//add your own walk behavior for your walker here.
		//Make sure to only use the outputs listed below.

		pastPositions.Add(playerPos); //

		int direction = Random.Range(0, possibleDirections.Count);

		Vector2 walkPos = possibleDirections[direction];

		Vector2 nextDir = playerPos + walkPos; //

		if (!HasVisited(nextDir, pastPositions))
        {
			walkPos = possibleDirections[direction];

			pastPositions.Add(walkPos);
        }


		if ((walkPos + playerPos).x < 0)
        {
            walkPos.x = 0;
        }
		else if ((walkPos + playerPos).x > areaWidth)
        {
			walkPos.x = areaWidth;
        }

		if ((walkPos + playerPos).y < 0)
        {
			walkPos.y = 0;
        }
		else if ((walkPos + playerPos).y > areaHeight)
        {
			walkPos.y = areaHeight;
        }

		return walkPos;
	}

	private bool HasVisited(Vector2 pos, List<Vector2> listpos)
    {
		bool hasVisited = false;

        for (int i = 0; i < listpos.Count; i++)
        {
			float distSqr = Vector2.SqrMagnitude(pos - listpos[i]);

			if (distSqr < 0.001f)
            {
				hasVisited = true;
				break;
            }
        }

		return hasVisited;
    }

	// TODO fix hasvisited and outofbounds 

}

//All valid outputs:
// Vector2(-1, 0); left
// Vector2(1, 0); right
// Vector2(0, 1); up
// Vector2(0, -1); down

//Any other outputs will kill the walker!
