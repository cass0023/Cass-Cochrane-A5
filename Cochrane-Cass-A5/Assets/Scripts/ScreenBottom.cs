using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformReset : MonoBehaviour
{
    public GameObject removePlatform;
    public Transform target;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (target.position.y > transform.position.y)
        {
            Vector3 newPosition = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = newPosition;
            
            if (collision.gameObject.CompareTag("Platform"))
            {
                Destroy(collision.gameObject);
            }
        }
    }
    void Update()
    {

    }
}
