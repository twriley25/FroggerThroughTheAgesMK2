using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditScroll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Move(Vector3.up);
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            Move(Vector3.down);
        }
    }

    private void Move(Vector3 directon)
    {
        Vector3 destination = transform.position + directon;

        transform.position = destination;
    }
}
