using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{

    private bool walking = false;
    private Vector3 spawnPoint;

    // Use this for initialization
    void Start()
    {
        spawnPoint = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (walking)
        {
            transform.position = transform.position + Camera.main.transform.forward * .5f * Time.deltaTime;
        }

        if (transform.position.x <= -4.4561f && (transform.position.z < 34.46957f && transform.position.z > 32.46957f))
        {
            transform.position = new Vector3(4.04f, -1.5f, 3f);
        }

        if(transform.position.x <= -3.470526f && (transform.position.z < 4f && transform.position.z > 2f))
        {
            transform.position = new Vector3(4.17f, -1.5f, 17.04f);
        }

        if (transform.position.x <= -4.64f && (transform.position.z < 17.4f && transform.position.z > 15f))
        {
            transform.position = spawnPoint;
        }


        if (transform.position.y < -10f)
        {
            transform.position = spawnPoint;
        }

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(.5f, .5f, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.name.Contains("plane"))
            {
                walking = false;
            }
            else
            {
                walking = true;
            }
        }

    }
}
