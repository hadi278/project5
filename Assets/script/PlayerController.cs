using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float horizontalInput;   
    public float speed = 10.0f;
    public float xrange = 10;
    public GameObject projectilePrepabs;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput  = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput *Time.deltaTime*  speed  );
        if (transform.position.x <-xrange)
        {
            transform.position = new Vector3(-xrange, transform.position.y, transform.position.z);
        }else if (transform.position.x > 10)
        {
            transform.position = new Vector3(xrange, transform.position.y, transform.position.z);

        }


        if (Input.GetKeyDown(KeyCode. Space))
        {
            Instantiate(projectilePrepabs, transform.position, projectilePrepabs.transform.rotation);        }
    }
}
