using UnityEngine;
using System.Collections;

public class SquampGrounded : MonoBehaviour {
    public Transform groundCheck;
    public bool IsGrounded = false;
    void Start()
    {

    }

    void Update()
    {
        IsGrounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
    }
}
