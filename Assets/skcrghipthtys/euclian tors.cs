using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eucliantors : MonoBehaviour
{
  public bool active;
  public float minimax;
  public float minimin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (active == true) { 
        // Teleport the game object
        if (transform.position.x > minimax)
        {

            transform.position = new Vector3(minimin, transform.position.y, 0);

        }
        else if (transform.position.x < minimin)
        {
            transform.position = new Vector3(minimax, transform.position.y, 0);
        }

        else if (transform.position.y > minimax)
        {
            transform.position = new Vector3(transform.position.x, minimin, 0);
        }

        else if (transform.position.y < minimin)
        {
            transform.position = new Vector3(transform.position.x, minimax, 0);
        }
      }
    }
}
