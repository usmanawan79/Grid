using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 offset = new Vector3(0, 2, 0);
    private Grid grid;
    GameObject  Childtext;

   
   // public GameObject cube;
    void Start()
    {
       grid = GameObject.Find("GridManager").GetComponent<Grid>();
      // Childtext = cube.transform.GetChild (0).gameObject;
       //Childtext.SetActive(false);
    }
    void Update()
    {
       // RaycastHit hit;
       // Ray fwd=new Ray(transform.position,Vector3.forward );
        if (Input.GetKeyDown(KeyCode.W))
        {
            // Vector3 fwd = transform.TransformDirection(Vector3.forward);

        // if (Physics.Raycast(transform.position, fwd, 10)) 
        //         {
        //             Debug.Log("hit");
        //         }
    transform.Translate(new Vector3 (0,0,2));
        }
                    //Childtext.SetActive(true);
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            
            transform.Translate(new Vector3(-2, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -2));
        }
        if (Input.GetKeyDown(KeyCode.D) )
        {
            transform.Translate(new Vector3(2, 0, 0));
        }

    }
}
