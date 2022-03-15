using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grid: MonoBehaviour
{
  public GameObject cube;
    private GameObject[,] grid;
    public int height ;
    public int width ;
    public GameObject player;

    void Start()
    {
        List<string> birds = new List<string>();
        birds.Add("pigeon");
        birds.Add("Hen"); 
        birds.Add("Swan");
        birds.Add("Crow");
        birds.Add("Parrot");
       // GameObject  Childtext = cube.transform.GetChild (0).gameObject;

        grid = new GameObject[width, height];
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                grid[i, j] = Instantiate(cube, new Vector3(i * 2, 0, j * 2), Quaternion.identity);
                grid[i, j].GetComponentInChildren<TextMesh>().text = birds[Random.Range(0, birds.Count)];
            }
        }
    }

}





















    // Update is called once per frame
    //void Update()
    //{
    //    RaycastHit hit;
    //    // If you have more than one camera, assign the right one through inspector to some variable and use that
    //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

    //    if (Physics.Raycast(ray, out hit))
    //    {
    //        Vector3 hitPos = hit.point;
    //        Vector3 gridPos = new Vector2(Mathf.Round(hitPos.i), Mathf.Round(hitPos.j));
    //        if (Input.GetMouseButtonDown(0)) // lmb pressed
    //        {
    //            pressedLmbLast = true;
    //            mouseDownCubePosition = gridPos;
    //            Debug.Log("Clicked on Cube: " + gridPos + BirdNames);
    //            //Destroy(grid[(int)gridPos.i, (int)gridPos.y]);
    //        }
    //        else if (Input.GetMouseButtonUp(0) && pressedLmbLast) // lmp released
    //        {
    //            pressedLmbLast = false;
    //            mouseUpCubePosition = gridPos;
    //            Debug.Log("Released on Cube: " + gridPos + BirdNames);

    //            List<GameObject> roadCubes = new List<GameObject>();
    //            // We want the difference, so only the positive value
    //            int iDiff = Mathf.Abs((int)mouseDownCubePosition.i - (int)mouseUpCubePosition.i);
    //            int jDiff = Mathf.Abs((int)mouseDownCubePosition.y - (int)mouseUpCubePosition.y); // remember this is j

    //            // We know how many blocks, but not where to start. Find the smaller of the two values:
    //            int iStart = mouseDownCubePosition.i < mouseUpCubePosition.i ?
    //                (int)mouseDownCubePosition.i : (int)mouseUpCubePosition.i;
    //            int jStart = mouseDownCubePosition.y < mouseUpCubePosition.y ?
    //                (int)mouseDownCubePosition.y : (int)mouseUpCubePosition.y;

    //            // Iterate over all cubes in the defined range to get cubes on our path
    //            // Note: dont use nested loops, or you get the entire area, not its outline/path
    //            for (int i = iStart; i < (iStart + iDiff); i++)
    //            {
    //                roadCubes.Add(grid[i, jStart]);
    //            }
    //            for (int j = jStart; j < (jStart + jDiff); j++)
    //            {
    //                roadCubes.Add(grid[iStart, j]);
    //            }

    //            Debug.Log("Road consists of " + roadCubes.Count + " cubes.");

    //            // All cubes that make up our road are now saved in roadCubes
    //            // Do what you want with them, for eiample delete them or change their color:
    //            foreach (GameObject cube in roadCubes)
    //            {
    //                cube.GetComponent<Renderer>().material.color = Color.black;
    //            }
    //        }
    //    }
    //}

