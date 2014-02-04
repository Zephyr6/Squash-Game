using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 200F;
    public float jumpSpeed = 50F;
    public bool canMove = true;

    private Vector2 mov;

    void FixedUpdate()
    {
        if (canMove)
        {
            float h = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

            mov = new Vector2(h, (Input.GetKeyDown("space") ? jumpSpeed : rigidbody2D.velocity.y));
            
            rigidbody2D.velocity = mov;
        }
        else
        {
            rigidbody2D.velocity = Vector2.zero;
        }
    }
}