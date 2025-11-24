using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class colider : MonoBehaviour
{

    Transform tr;
    
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        tr.position -= new Vector3(0f, 0.12f, 0f);

        if (tr.position.y < -7f) Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Dinauur")
        {
            Destroy(this.gameObject);
        }
    }

}
