using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateScript : MonoBehaviour
{

    public GameObject maze;

    private void OnTriggerEnter(Collider other)
    {
        maze.transform.Rotate(0, 0, -180, Space.Self);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //maze.transform.Rotate(Vector3.right * Time.deltaTime*20);
        // maze.transform.Rotate(Vector3.right * 180);
        //maze.transform.Rotate(0, 0, 180, Space.Self);
    }
}
