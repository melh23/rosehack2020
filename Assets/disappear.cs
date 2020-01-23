using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappear : MonoBehaviour
{
    public GameObject heart;
    // Start is called before the first frame update
    void Start()
    {
    
        {
           heart.transform.Rotate(Vector3.right * Time.deltaTime * 5);
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        heart.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
