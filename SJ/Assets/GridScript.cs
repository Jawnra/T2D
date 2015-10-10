using UnityEngine;
using System.Collections;

public class GridScript : MonoBehaviour
{
    public GameObject tile;
    public Vector2 dimensions;
    public float spacer;


	// Use this for initialization
	void Start()
    {
        dimensions = new Vector2(5, 5);
        spacer = 1.1f;

        CreateTiles();
	}
	
	// Update is called once per frame
	void Update()
    {
	    
	}

    private void CreateTiles()
    {
        float xOS = 0;
        float yOS = 0;

        for (int x = 0; x < dimensions.x; x++)
        {
            xOS += spacer;
            yOS = 0;

            for (int y = 0; y < dimensions.y; y++)
            {
                if ((x + 1) % dimensions.x == 0)
                    xOS = 0;

                yOS += spacer;
                Instantiate(tile, new Vector3(transform.position.x + xOS, transform.position.y + yOS), transform.rotation);
                
            }
        }
    }
}
