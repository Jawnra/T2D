using UnityEngine;
using System.Collections;
using rng = UnityEngine.Random;
using System.Collections.Generic;
using Assets;

public class Pipe : MonoBehaviour
{
    List<Dir> openSides;

	// Use this for initialization
	void Start()
    {
        openSides = new List<Dir>()
        {
            Dir.Up, Dir.Down, Dir.Left, Dir.Right
        };

        int rand = rng.Range(1, 10);

        if (rand < 8) //1-7 means two open sides
        {
            int removeSide = rng.Range(1, 4);
            openSides.RemoveAt(removeSide);
            removeSide = rng.Range(1, 3);
            openSides.RemoveAt(removeSide);
        }
        else if (rand < 10) //8 or 9 means three open sides
        {
            int removeSide = rng.Range(1, 4);
            openSides.RemoveAt(removeSide);
        }
        //If rand is 10, no sides will be removed.
	}
    private void CreateSides()
    {
    }
	
	// Update is called once per frame
	void Update()
    {
	    
	}
}
