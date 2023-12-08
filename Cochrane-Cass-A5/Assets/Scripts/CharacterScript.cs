using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    public Rigidbody2D characterRb;
    public float speed = 8f;

    private float moveX;

    void Start()
    {
        characterRb.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //creates x movement and adds speed every level passed
        float newSpeed = speed;
        moveX = Input.GetAxis("Horizontal") * newSpeed;
    }
    private void FixedUpdate()
    {
        Vector2 velocity = characterRb.velocity;
        velocity.x = moveX;
        characterRb.velocity = velocity;
    }
}
